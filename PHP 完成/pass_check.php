<?php
session_start();
require_once 'db_connect.php';
?>

<!DOCTYPE html>
<html lang=ja>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
   <script src="./script/script.js"></script>
   <script src="./script/jquery-2.2.1.min.js" type="text/javascript"></script>
<title>パスワード再入力</title>
</head>
<body>
<table>
<?php
$HTTP_REFERER = $_SERVER['HTTP_REFERER'];
//$previous = "javascript:history.go(-1)";
$gname1=empty($_POST["pass1"])?null:htmlspecialchars($_POST["pass1"],ENT_NOQUOTES,'UTF-8');
$gname2=empty($_POST["pass2"])?null:htmlspecialchars($_POST["pass2"],ENT_NOQUOTES,'UTF-8');
$gname1_len=strlen($gname1);
$gname2_len=strlen($gname2);
$err_count=0;
if(ctype_alnum($gname1)&&ctype_alnum($gname2)){
	echo'english and number pass';
	//ok
}else{
	//not
	echo'english and number pass fail';
	$_SESSION['eng_num_pass_err']="※パスワードは半角英数字(英数まぜ)だけ可能です。";
	var_dump($_SESSION['eng_num_pass_err']);
	$err_count++;
}

if($gname1_len>=6&&$gname1_len<=30){
	//ok
	echo "pass1 number length pass";
}else{
	//not
	echo "pass1 number length pass fail";
	$_SESSION['num_length_err']="※パスワードは６桁以上30桁以内可能です。";
	$err_count++;
	var_dump($_SESSION['num_length_err']);
}
if($gname1==$gname2){
	echo "pass1,pass2 match pass";
}else{
	//not
	echo "pass1,pass2 match pass fail";
	$err_count++;
	$_SESSION['match_err']="※パスワードが一致しません。";
	var_dump($_SESSION['match_err']);
}
if($gname1_len!=0){
	echo "pass1 blank pass";
}else{
	//not
	echo "pass1 blank pass fail";
	$err_count++;
	$_SESSION['pass1_blank_err']="※パスワード入力必須です";
	var_dump($_SESSION['pass1_blank_err']);
}
if($gname2_len!=0){
	echo "pass2 blank pass";
}else{
	//not
	echo "pass2 blank pass fail";
	$err_count++;
	$_SESSION['pass2_blank_err']="※パスワードもう一度入力は必須です。";
	var_dump($_SESSION['pass2_blank_err']);
}
$sql = $dbh ->prepare( 'select UserNumber,MailAddress from LibraryUser
						where UserNumber like ? ');
$sql->execute(array($_SESSION['ses_userid']));
while($row = $sql->fetch( PDO::FETCH_ASSOC)){
	if($gname1!=$row ["UserNumber"]){
		//ok
	}else{
		//fail
		$err_count++;
		$_SESSION['pass2_info_err']="※学籍情報はパスワードにはなりません。";
		var_dump($_SESSION['pass2_info_err']);
	}
	if($gname1!=$row ["MailAddress"]){
		//ok
	}else{
		//fail
		$err_count++;
		$_SESSION['pass2_info_err']="※学籍情報はパスワードにはなりません。";
		var_dump($_SESSION['pass2_info_err']);
	}

}

if($err_count==0){
	$_SESSION['pass_gname1']=$gname1;
	$_SESSION['pass_gname2']=$gname2;
	header('Location: passConfirm.php');
}else{
	header('location:'.$HTTP_REFERER);
}
?>
</table>
</body>
</html>

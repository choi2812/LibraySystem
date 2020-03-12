<?php
	require_once 'db_connect.php';
	session_start();
?>
<!doctype html>
<html lang=''>
<head>
   <meta charset='utf-8'>
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="./css/style_1.css">
   <script src="./script/script.js"></script>
   <script src="./script/jquery-2.2.1.min.js" type="text/javascript"></script>
   <title>日本電子中央図書館</title>
</head>
<body>
<script>
	function button1_click(number) {
		alert("すでに貸し出している蔵書は予約できません。");
		history.go(-1);
	}
	function button2_click(number) {
			alert("すでに予約した蔵書です。");
			history.go(-1);
	}
	function button3_click(number) {
		alert("蔵書番号"+number+"予約完了しました。");
		history.go(-1);
	}
	function button4_click(number) {
		alert("ログインが必要なサービスです。");
		location.href="./login.php? booknumber=" + number;
	}
</script>
<?php
if (isset($_SESSION['ses_userid'])) {
	$year = date('Y');
	$month = date('m');
	$day = date('d');
	$book=(empty($_GET["booknumber"])?null:htmlspecialchars($_GET["booknumber"],ENT_NOQUOTES,'UTF-8'));
	$sql = $dbh ->prepare( 'select * FROM Borrow
							WHERE UserNumber= ?
							and LibraryNumber= ?
							and ReturnDate is null');
	$sql->execute(array($_SESSION['ses_userid'],$book));
	$row = $sql->fetch( PDO::FETCH_ASSOC);

	if($row != null){
		$book=(empty($_GET["booknumber"])?null:htmlspecialchars($_GET["booknumber"],ENT_NOQUOTES,'UTF-8'));
		echo"<script language='javascript'>button1_click('".$book."');</script>";
	}else{

		$book=(empty($_GET["booknumber"])?null:htmlspecialchars($_GET["booknumber"],ENT_NOQUOTES,'UTF-8'));

		$sql1 = $dbh ->prepare( 'select * FROM Booking
									WHERE UserNumber= ?
									and LibraryNumber= ?');
		$sql1->execute(array($_SESSION['ses_userid'],$book));
		$row = $sql1->fetch( PDO::FETCH_ASSOC);
		if ($row != false) {//ari
			echo("<script language='javascript'>button2_click('".$book."');</script>");
		}else{
			$sql1 = $dbh ->prepare( 'INSERT INTO Booking (UserNumber,RegisterDate,BookingDate,LibraryNumber)
										VALUES( ? ,null, ? , ? )');
			$sql1->execute(array($_SESSION['ses_userid'],date("Y-m-d",time()),$book));
			echo("<script language='javascript'>button3_click('".$book."');</script>");
		}
	}

}else{
	$book=(empty($_GET["booknumber"])?null:htmlspecialchars($_GET["booknumber"],ENT_NOQUOTES,'UTF-8'));
	echo"<script language='javascript'>button4_click('".$book."');</script>";
}


?>
</body>
</html>
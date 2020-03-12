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
	function button2_click(number) {
			alert("蔵書番号"+number+"延長完了しました。");
			history.go(-1);
	}
</script>
<?php
	$book=(empty($_GET["booknumber"])?null:htmlspecialchars($_GET["booknumber"],ENT_NOQUOTES,'UTF-8'));

	$sql1 = $dbh ->prepare( 'select ScheduleReturnDate from Borrow where UserNumber= ?
							 and LibraryNumber= ? ');
	$sql1->execute(array($_SESSION['ses_userid'],$book));
	while($row1 = $sql1->fetch( PDO::FETCH_ASSOC)){
		//echo $row1 ["ScheduleReturnDate"];
		$new_date=date('Y-m-d',strtotime($row1 ["ScheduleReturnDate"].'+'.'7'.' days'));
		$sql = $dbh ->prepare( 'update Borrow
								set ScheduleReturnDate= ?
								where UserNumber= ?
								and LibraryNumber= ? ');
		$sql->execute(array($new_date,$_SESSION['ses_userid'],$book));
		$sql2 = $dbh ->prepare( 'update Borrow
								set ExtensionFlag= ?
								where UserNumber= ?
								and LibraryNumber= ? ');
		$sql2->execute(array('1',$_SESSION['ses_userid'],$book));
	}
	 echo("<script language='javascript'>button2_click('".$book."');</script>");


?>
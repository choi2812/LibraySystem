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
			alert("蔵書番号"+number+"予約取り消し完了しました。");
			history.go(-1);
	}
</script>
<?php
$book=(empty($_GET["booknumber"])?null:htmlspecialchars($_GET["booknumber"],ENT_NOQUOTES,'UTF-8'));
//입하일 있고
//뒤에 예약자가 없을 경우 플러그 세움
//echo "0";
//echo "1";
//echo "2";
//echo "3";
//echo "4";
//echo "5";
//echo "6";
	$sql5 = $dbh ->prepare( 'SELECT *FROM Booking
								where LibraryNumber= ? ');
	$sql5->execute(array($book));
	while ($row = $sql5->fetch( PDO::FETCH_ASSOC)) {
		//var_dump($row ["UserNumber"]);
		$Re=$row ["RegisterDate"];
		break;
	}

	$sql1 = $dbh ->prepare( 'DELETE FROM Booking
								WHERE UserNumber= ?
								and LibraryNumber= ? ');
	$sql1->execute(array($_SESSION['ses_userid'],$book));

	//예약 삭제함.

	$sql3 = $dbh ->prepare( 'select * from Booking
								where LibraryNumber= ? ');
	$sql3->execute(array($book));
	$row3 = $sql3->fetch( PDO::FETCH_ASSOC);
	if ($row3 != false) {//次の予約者あり
      // echo"ss";
		$sql4 = $dbh ->prepare( 'update Booking set RegisterDate= ?
									where LibraryNumber= ?
									and BookingNumber=
									(SELECT MIN(BookingNumber) from Booking  WHERE LibraryNumber= ? )');
		$sql4->execute(array($Re,$book,$book));

		$sql2 = $dbh ->prepare( 'select * from Booking
								where LibraryNumber= ?
								and RegisterDate is not null ');
		$sql2->execute(array($book));
		$row2 = $sql2->fetch( PDO::FETCH_ASSOC);
		if ($row2 != false) {//入荷日あり//予約者あり
			//echo"rr";
			$sql = $dbh ->prepare( 'select Title,LibraryUser.UserNumber,LibraryUser.UserName,MailAddress from Booking,LibraryUser,Book,Library
									where Booking.UserNumber=LibraryUser.UserNumber
									and Book.BookNumber=Library.BookNumber
									and Library.LibraryNumber=Booking.LibraryNumber
									and Library.LibraryNumber= ? ');
			$sql->execute(array($book));
			while ($row = $sql->fetch( PDO::FETCH_ASSOC)) {
				$row ["Title"];
				//var_dump($row ["Title"]);
				$row ["UserName"];
				//var_dump($row ["UserName"]);
				$row ["MailAddress"];
				//var_dump($row ["MailAddress"]);
				break;
			}
			$to = $row ["MailAddress"];

			$subject ="【日本電子専門学校図書館】予約蔵書入荷のお知らせ";

			$mail="
{$row ["UserName"]}様
日本電子専門学校図書館のご利用ありがとうございます。
以前予約した蔵書".$row ["Title"]."が入荷しました。
お申し込みは下記の内容で承りました。
予約した本を3日間以内借りに来ない場合自動取り消しになりますのでご注意ください。

■蔵書番号:".$book."
■蔵書名:".$row ["Title"]."

■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□
■お問い合わせ先
■日本電子専門学校図書館
■TEL     ：03-xxx-xxx 受付時間：09:00-20:00（土・日・祝日をのぞく）
■E-MAIL：info@jec.ac.jp
■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□
■注意事項
■他のお問い合わせ等は上記の連絡先にお願いします。
■このメールはコンピュータシステムによって自動的に送信しています。
■このため、お問い合わせ等をこのメールに返信いただいても回答できません。
";

			$body =$mail;

			mb_send_mail ( $to, $subject, $body, "From:14jy0123@jynet.jec.ac.jp" );
			//echo'55';
		}
	}else{//入荷日ﾅｼ
		//echo'11';
		$sql7 = $dbh ->prepare( 'select * from Booking
									where LibraryNumber= ? ');
		$sql7->execute(array($book));
		$row7 = $sql7->fetch( PDO::FETCH_ASSOC);
		if ($row7 != false){
		//echo'ee';
		}else{
			$ze=0;
			$sql4 = $dbh ->prepare( 'update Library set BorrowFlag= ?
									where LibraryNumber= ? ');
			$sql4->execute(array($ze,$book));
		//echo'9999';
		}
	}

	 echo("<script language='javascript'>button2_click('".$book."');</script>");


?>
</body>
</html>
<?php
session_start();
require_once 'db_connect.php';

mb_language ( "japanese" );
mb_internal_encoding ( "UTF-8" );
$sql = $dbh ->prepare( 'update LibraryUser
						set UserPassWord = ?
						where UserNumber= ? ');
$sql->execute(array($_SESSION['pass_gname1'],$_SESSION['ses_userid']));

$_SESSION['ses_pass']=$_SESSION['pass_gname1'];

$sql = $dbh ->prepare( 'select MailAddress
						from LibraryUser
						where UserNumber like ? and UserPassWord like ? ');
$sql->execute(array($_SESSION['ses_userid'],$_SESSION['ses_pass']));
while ($row = $sql->fetch( PDO::FETCH_ASSOC)) {
	$MailAddress=$row ["MailAddress"];
}
$to = $MailAddress;

$subject ="【日本電子専門学校図書館】パスワード変更のお知らせ";

$mail="{$_SESSION['ses_userid']}様
日本電子専門学校図書館のご利用ありがとうございます。
パスワード変更のお申込みを受け付けました。
お申し込みは下記の内容で承りました。


■パスワード：{$_SESSION['ses_pass']}

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

?>
<!doctype html>
<html lang=''>
<head>
   <meta charset='utf-8'>
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1">
   <link rel="stylesheet" href="./css/stayle_left.css">
   <script src="./script/script.js"></script>
   <script src="./script/jquery-2.2.1.min.js" type="text/javascript"></script>
   <title>日本電子中央図書館</title>
</head>
<body>
<div id="header">
	<h1><a href="./topMain.php" title="日本電子中央図書館"><span class="hidden">日本電子中央図書館</span></a></h1>
</div>

<div id='cssmenu'>
<ul>
   <li><a href='./topMain.php'><span>Home</span></a></li>
   <li class='active has-sub'><a href='./detailsSearch.php'><span>蔵書検索</span></a>
      <ul>
         <li class='has-sub'><a href='./detailsSearch.php'><span>詳細検索</span></a></li>
         <li class='has-sub'><a href='./newBookSearch.php'><span>新着・削除予定資料検索</span></a></li>
      </ul>
   </li>
   <li class='active has-sub'><a href='./libraryInfo.php'><span>図書館案内</span></a>
      <ul>
         <li class='has-sub'><a href='./libraryInfo.php'><span>図書館案内</span></a></li>
         <li class='has-sub'><a href='./donationInfo.php'><span>資料寄贈案内</span></a></li>
      </ul>
   </li>
   <li><a href='./FQAInfo.php'><span>FAQ</span></a></li>
</ul>
</div>
<div id="container">
	<div id="main">
	<form method="post" action="topMain.php">
		<h2>パスワード変更完了</h2>
		<p><img src="img/passTrans3.png" width="800" height="100" alt="pic_Error"/></p>
		<fieldset>
			<legend><strong>パスワード変更確認メッセージ<br>パスワード変更送信</strong></legend>
				<p>ありがとうございます。<br>パスワード変更が無事完了さらました。<br> ご登録のメールアドレスにパスワード変更メールをお送りいたしました。<br>ご確認ください。</p>
				<input type="submit" value="HOMEに戻る">
		</fieldset>
		</form>
	</div>
</div>
<?php header("Pragma: no-cache");
			header("Cache-Control: no-cache,must-revalidate");?>
</body>
</html>
<?php
session_start();
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
		<form method="post" action="passTransComplete.php">
		<h2>パスワード変更確認</h2>
		<p><img src="img/passTrans2.png" width="800" height="100" alt="pic_Error"/></p>
		<fieldset>
			<legend><strong>パスワード変更確認フォーム</strong></legend>
				<p>新しいパスワードでパスワード変更します。</p>
				<table border="1" >
					<tr>
						<th>入力されたパスワード</th>
			 <?php echo"<td>".$_SESSION['pass_gname1']."</td>";?>
					</tr>
					<tr>
						<th>再入力されたパスワード</th>
			 <?php echo"<td>".$_SESSION['pass_gname2']."</td>";
				 $_SESSION['pass_gname2']=null;?>

					</tr>
				</table>
			 <?php echo"<p>パスワードを".$_SESSION['pass_gname1']."に変更しますか。</p>"?>
				<p><input type="button" value="＜＜パスワード修正 "  onClick="javascript:history.back();">&#160;&#160;&#160;<input type="submit" value="パスワード確定＞＞"></p>
		</fieldset>
		</form>
		<?php
		header("Pragma: no-cache");
			header("Cache-Control: no-cache,must-revalidate");
			?>
	</div>
</div>
</body>
</html>
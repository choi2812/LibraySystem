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
	<form method="post" action="pass_check.php">
		<h2>パスワード変更申し込み</h2>
		<p><img src="img/passTrans1.png" width="800" height="100" alt="pic_Error"/></p>
		<fieldset>
			<legend><strong>パスワード変更フォーム</strong></legend>
				<p>新しいパスワードを 入力してください。</p>
				<table border="1" >
					<tr>
						<th>パスワード【必須】</th>
						<td><input type="text"  size="35"name="pass1">
						<?php
						if(isset($_SESSION['eng_num_pass_err'])){
							echo "<p><font size=4 color=red>".$_SESSION['eng_num_pass_err']."</font></p>";
							$_SESSION['eng_num_pass_err']=null;
						}
						if(isset($_SESSION['num_length_err'])){
							echo "<p><font size=4 color=red>".$_SESSION['num_length_err']."</font></p>";
						}
						if(isset($_SESSION['pass1_blank_err'])){
							echo "<p><font size=4 color=red>".$_SESSION['pass1_blank_err']."</font></p>";
							$_SESSION['pass1_blank_err']=null;
						}
						if(isset($_SESSION['pass2_info_err'])){
							echo "<p><font size=4 color=red>".$_SESSION['pass2_info_err']."</font></p>";
							$_SESSION['pass2_info_err']=null;
						}
						?>
							<p style="color:blue; font-size:15px">登録メールアドレス使用できません。<br>半角英数字(英数まぜ)で6桁以上30桁以内</p>
						</td>
					</tr>
					<tr>
						<th>パスワードもう一度入力【必須】</th>
						<td><input type="text"size="35"  name="pass2">
						<?php
						if(isset($_SESSION['num_length_err'])){
							echo "<p><font size=4 color=red>".$_SESSION['num_length_err']."</font></p>";
							$_SESSION['num_length_err']=null;
						}
						if(isset($_SESSION['match_err'])){
							echo "<p><font size=4 color=red>".$_SESSION['match_err']."</font></p>";
							$_SESSION['match_err']=null;
						}
						if(isset($_SESSION['pass2_blank_err'])){
							echo "<p><font size=4 color=red>".$_SESSION['pass2_blank_err']."</font></p>";
							$_SESSION['pass2_blank_err']=null;
						}
						?>
						<p style="color:blue; font-size:15px">確認のためもう一度入力してください。</p></td>
					</tr>
				</table>
				<p><input style="margin-left:250px;" type="submit" value="パスワード確認＞＞"></p>
		</fieldset>
	</form>
</div>
</div>
</body>
</html>
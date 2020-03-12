<?php
	require_once 'db_connect.php';
	session_start();
	$_SESSION['booknumber']=(empty($_GET["booknumber"])?null:htmlspecialchars($_GET["booknumber"],ENT_NOQUOTES,'UTF-8'));
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
   <script type="text/javascript">
	function test(){
		log_form.fuserid.focus();
		alert("パスワードを忘れた場合は\n図書館で本人確認の上で初期化ができます。");
	}
	function login(){
		if(log_form.fuserid.value==""||log_form.fpasswd.value==""){
			alert("学籍番号又はパスワードが間違ってログインできません。\n 学籍番号又はパスワードを確認してください。");
			log_form.fuserid.focus();
			return false;
		}else{
			return true;
		}
	}
	function test_call(){
		alert('学籍番号又はパスワードが間違ってログインできません。\n 学籍番号又はパスワードを確認してください。');
		login_form.fpasswd.focus();
	}
	</script>
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
	<form name="log_form" method="post" onsubmit="return login();" action="login_judge.php">
		<h2>LOG-IN</h2>
		<fieldset>
			<legend><strong>LOG-INしてください！</strong></legend>
				<p>利用する前にはログインが必要です。</p>
				<table>
					<tr>
						<th>学籍番号：<input type="text"  size="35" name="fuserid"></th>
					</tr>
					<tr>
						<th>パスワード：<input type="password"size="35"  name="fpasswd"></th>
					</tr>
					<tr>
					<td><input type="submit" value="ログイン&gt;&gt;" style="width:150px; margin:30px 50px 0px 200px;" onclick="login();"></td>
					<td><input type="button" value="パスワードを忘れの方こちらからどうぞ" onclick="test();" style="margin:30px 0px 0px 50px;"></td>
				</tr>

				</table>
				<?php
			if(isset($_SESSION['err'])){
				echo("<script>test_call();</script>");
				$_SESSION['err']=null;
			}
			?>
		</fieldset>
		</form>
	</div>
</div>
</body>
</html>
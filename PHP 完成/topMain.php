<?php
session_start();//세션의 시작

/* --- 세션 값이 있으면 로그인 한 것으로 간주하여 로그인 성공 화면으로 이동 --- */
if (empty($_SESSION['ses_userid'])){
	$var1="";
}else{
	header('Location: topMain_login.php');
   die;
}
?>
<!doctype html>
<html lang=''>
<head>
   <meta charset='utf-8'>
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1">
   <link rel="stylesheet" href="./css/styles.css">
   <script src="./script/script.js"></script>
   <script src="./script/jquery-2.2.1.min.js" type="text/javascript"></script>
   <title>日本電子中央図書館</title>
</head>
<body>
<script type="text/javascript">
	function test(){
		alert("パスワードを忘れた場合は\n図書館で本人確認の上で初期化ができます。");
	}

	function chk_logform() {
		if(login_form.fuserid.value=="") {
			alert('学籍番号又はパスワードが間違ってログインできません。\n 学籍番号又はパスワードを確認してください。');
			login_form.fuserid.focus();
			return false;
		} else if(login_form.fpasswd.value=="") {
			alert('学籍番号又はパスワードが間違ってログインできません。\n 学籍番号又はパスワードを確認してください。');
			login_form.fpasswd.focus();
			return false;
		} else {
			return true;
		}
	}
	function test_call(){
		alert('学籍番号又はパスワードが間違ってログインできません。\n 学籍番号又はパスワードを確認してください。');
		login_form.fpasswd.focus();
	}
</script>
<form method="post" action="selectBook.php">
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
			<div id="topimage">
				<span class="hidden">バックパックサマーセール</span>
			</div>
			<h2>簡易検索</h2>
			<p><input type="text" name="find" size="50">&#160;<input type="submit" value="検索" ></p>
			<p>会館時間 :AM　9時　-　PM　5時まで</p>
		</div>
</form>
<form name="login_form" action="login_judge.php" method="post" onsubmit="return chk_logform();">
		<div id="siderbar">
		<h3>LOG-IN</h3>
		<ul>
			<li>学籍番号<input type="text" name="fuserid" id="fuserid" size="19"></li>
			<li>パスワード<input type="password" name="fpasswd" id="fpasswd" size="20"></li>
			<li><input type="button" value="パスワードを探す>>" onclick="test();">&nbsp;<input type="submit" name="Submit" value="ログイン"></li>
			<?php
			if(isset($_SESSION['err'])){
				echo("<script>test_call();</script>");
				$_SESSION['err']=null;
			}
			?>
		</ul>
		<h3>PICK UP</h3>
		<a href="http://www.jec.ac.jp/"><img src="img/logo.gif" width="200" height="90" alt="pic_Error"/></a>
		<a href="https://sip3.jec.ac.jp/"><img src="img/info.GIF" width="200" height="90" alt="pic_Error"/></a>
		<a href="https://www.jh.jec.ac.jp"><img src="img/title_top.gif" width="200" height="90" alt="pic_Error"/></a>
</form>
		</div>
	</div>
</body>
</html>

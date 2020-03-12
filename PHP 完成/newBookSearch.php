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
<form name="details_form" method="post" action="selectBook3.php">
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
<form method="post" action="selectBook3.php">
		<fieldset>
			<legend><h2>新着資料検索</h2></legend>

				<label><input type="radio" name="radio1" value="1" checked="ture"/>1週間</label>
				&#160;&#160;
				<label><input type="radio" name="radio1" value="2" />2週間</label>
				&#160;&#160;
				<label><input type="radio" name="radio1" value="3" />3週間</label>
				&#160;&#160;
				<label><input type="radio" name="radio1" value="4" />10年以上の削除予定蔵書</label>
		</fieldset>
		<input type="submit" value="検索" name="sub1">
</form>
	</div>
</div>
</form>
</body>
</html>

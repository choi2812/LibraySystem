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
		<h2>図書館案内</h2>
		<fieldset>
			<legend>案内リスト</legend>
				<p><a href="libraryInfo.php#kaikannjikan">開館時間</a></p>
				<p><a href="libraryInfo.php#kasidasinagare">貸し出しの流れ</a></p>
				<p><a href="libraryInfo.php#kasidasi">貸し出し</a></p>
				<p><a href="libraryInfo.php#henkyaku">返却</a></p>
				<p><a href="libraryInfo.php#yoyaku">蔵書予約</a></p>
				<p><a href="libraryInfo.php#funnsitu">蔵書紛失</a></p>
		</fieldset>
		<h3><a id="kaikannjikan"> &lt; 開館時間  &gt;</a></h3>
			<p>AM　9時　-　PM　5時まで</p>

		<h3><a id="kasidasinagare"> &lt; 貸し出しの流れ  &gt;</a></h3>
			<p><img	src = "img/kasidasinagare.png"  width="900" height="100" alt="紅葉風景//에러 메세지"></p>

		<h3><a id="#kasidasi"> &lt; 貸し出し &gt;</a></h3>
		<ol>
			<li>貸し出ししようと思う図書を中央図書館ホームページから検索し、所蔵されている場所と貸し出し可能などの基本情報を確認する。</li>
			<li>貸し出しが可能な場合、蔵書を探しデスクに貸し出しする蔵書を持ち出し学生証（又は教員証）を提示し蔵書を貸し出しする。</li>
			<li>貸し出しする時、蔵書の中の返却日を確認する。</li>
		</ol>

		<h3><a id="#henkyaku"> &lt; 返却  &gt;</a></h3>
		<ol>
			<li>貸し出しした蔵書は図書室のデスク又は図書館のドアの前の無人返却機で返却できます。</li>
			<li>蔵書と一緒に貸し出しした付録(付録：小冊子、 CD-ROM、 Tape など)は必ず貸し出しした蔵書と一緒に返却してください。(蔵書と付録は別々返却不可、無人返却機使用不可)</li>
		</ol>

		<h3><a id="#yoyaku"> &lt; 蔵書予約  &gt;</a></h3>
		<ol>
			<li>貸し出しする蔵書がすべて「貸し出し中」の場合、予約できます。</li>
			<li>ログインの後、貸し出しする蔵書の詳細で予約のボタンをクリックし予約できます。</li>
			<li>予約した蔵書が返却されたら図書館に登録されたメールアドレスでメールを送りますので本人のメールアドレスを変わった場合、図書館で変更してください。</li>
			<li>予約図書到着メールをもらった日を含め３日以内に図書館デスクに訪問してください。</li>
		</ol>

		<h3><a id="#funnsitu"> &lt; 蔵書紛失 &gt;</a></h3>
		<ol>
			<li>貸し出し蔵書紛失時、図書館返済規定に基づいて同じ図書を返済します。</li>
			<li>品切れや絶版され同じ図書で返済できない場合は類似図書で返済します。</li>
			<li>類似図書の指定は司書が決め、新しい蔵書を原則とします。</li>
		</ol>
	</div>
</div>
</body>
</html>

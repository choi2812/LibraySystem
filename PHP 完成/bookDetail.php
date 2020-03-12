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
	<script>
	function button3_click(number) {
		if(confirm("蔵書番号"+number+"予約しますか？")){
			location.href="./yoyaku.php? booknumber=" + number;
		}
	}
	</script>
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
<?php
$gname1=empty($_GET["gid"])?null:htmlspecialchars($_GET["gid"],ENT_NOQUOTES,'UTF-8');

$key_gname=(int)$gname1;
$sql = null;
$row_cnt = 0;
$maker=null;
$line=1;
$sql = $dbh ->prepare( 'SELECT Title,ISBN,TitleKana,SubTitleKana,SubTitle,AName,ANameKana,PName,PNameKana,PublishedYear,Price,OptionName,OptionSpecification,Etc
						FROM  Book as B,OptionType as O,Genre as G,Publishcompany as P,Author as A
						WHERE   O.OptionNumber = B.OptionNumber
						and G.GNumber = B.GNumber
						and P.PNumber = B.PNumber
						and A.ANumber = B.ANumber
						and (B.BookNumber= ? ) ');
$sql->execute(array($key_gname));
while($row = $sql->fetch( PDO::FETCH_ASSOC)){
	echo"<h2>[".$row ["Title"]."]の詳細情報</h2>";
	echo"<table border=1>";
	echo"<tr>";
	echo"<th>ISBN</th>";
	echo"<td>".$row ["ISBN"]."</td>";
	echo "</tr>";
	echo "<tr>";
	echo"<th>書名(タイトル)</th>";
	echo"<td>".$row ["Title"]."</td>";
	echo"</tr>";
	echo"<tr>";
	echo"<th>書名(タイトル)かな</th>";
	echo"<td>".$row ["TitleKana"]."</td>";
	echo"</tr>";
	$subKana=strlen($row ["SubTitle"]);
	if($subKana==0){
		echo"<tr>";
		echo"<th>副書名(サブタイトル)</th>";
		echo "<td>なし</td>";
		echo"</tr>";
		echo"<tr>";
		echo"<th>副書名(サブタイトル)かな</th>";
		echo"<td>なし</td>";
		echo "</tr>";
	}else{
		echo"<tr>";
		echo"<th>副書名(サブタイトル)</th>";
		echo "<td>".$row ["SubTitle"]."</td>";
		echo"</tr>";
		echo"<tr>";
		echo"<th>副書名(サブタイトル)かな</th>";
		echo "<td>".$row ["SubTitleKana"]."</td>";
		echo "</tr>";
	}
	echo"<tr>";
	echo"<th>著者名</th>";
	echo"<td>".$row ["AName"]."</td>";
	echo"</tr>";

	echo"<tr>";
	echo"<th>著者名かな</th>";
	echo"<td>".$row ["ANameKana"]."</td>";
	echo"</tr>";

	echo"<tr>";
	echo"<th>出版社</th>";
	echo"<td>".$row ["PName"]."</td>";
	echo"</tr>";

	echo"<tr>";
	echo"<th>出版社かな</th>";
	echo"<td>".$row ["PNameKana"]."</td>";
	echo"</tr>";

	echo"<tr>";
	echo"<th>発行年</th>";
	echo"<td>".$row ["PublishedYear"]."</td>";
	echo"</tr>";

	echo"<tr>";
	echo"<th>価格</th>";
	echo "<td>&yen".number_format( floor($row ["Price"])) ."</td>\n";
	echo"</tr>";

	echo"<tr>";
	echo"<th>付属品明細</th>";
	echo"<td>".$row ["OptionName"]."/".$row ["OptionSpecification"]."</td>";
	echo"</tr>";

	echo"<tr>";
	echo"<th>備考</th>";
	echo"<td>".$row ["Etc"]."</td>";
	echo"</tr>";
	echo "</table>";
}
//貸出情報

	$sql = $dbh ->prepare( 'SELECT LibraryNumber,B.GNumber,BookShelfNumber,ANameInitial,OptionName,BorrowFlag
							FROM Book as B, Library as L,OptionType as O,Genre as G,Publishcompany as P,Author as A
							WHERE   O.OptionNumber = B.OptionNumber
							and G.GNumber = B.GNumber
							and P.PNumber = B.PNumber
							and A.ANumber = B.ANumber
							and L.BookNumber = B.BookNumber
							and (B.BookNumber= ? ) ');
	$sql->execute(array($key_gname));
	echo"<table border=\"1\">";
	echo"<caption>貸し出し情報</caption>";
	echo"<tr>";
	echo"<th>番号</th>";
	echo"<th>蔵書番号</th>";
	echo"<th>請求記号</th>";
	echo"<th>付録品名</th>";
	echo"<th>貸出状態</th>";
	echo"<th>予約</th>";
	echo"<th>予約者数</th>";
	echo"</tr>";
	while($row = $sql->fetch( PDO::FETCH_ASSOC)){
		echo"<tr>";
		echo"<td>".$line."</td>";
		echo"<td>".$row ["LibraryNumber"]."</td>";
		$current_member0 = $row ["LibraryNumber"];
		echo"<td>".$row ["GNumber"].$row ["BookShelfNumber"]."-".$row ["ANameInitial"]."</td>";
		echo"<td>".$row ["OptionName"]."</td>";
		if($row ["BorrowFlag"]==0){
			echo "<td><strong>貸し出し可能</strong></td>\n";
			echo "<td> </td>\n";
		}else{
			echo "<td>貸し出し中 </td>\n";
			echo "<td>";
			echo "<input type=\"button\" value=\"予約\" onclick=\"button3_click('".$current_member0."');\" >";
			echo "</td>";
		}
		$sql2 = $dbh ->prepare( 'select count(*) as cnt from Booking where LibraryNumber=?');
		$sql2->execute(array($current_member0));
		$row2 = $sql2->fetch( PDO::FETCH_ASSOC);
		echo "<td>".$row2['cnt']."</td>";
		echo"</tr>";
	}
	echo "</table>";

	echo"<input type=\"button\" value=\"戻る\" onclick=\"javascript:history.go(-1)\">";

$dbh = null;
?>
	</div>
</div>
</body>
</html>

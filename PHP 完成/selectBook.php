<?php
	require_once 'db_connect.php';
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
$gname_len=strlen($_POST["find"]);
$gname=strtolower(empty($_POST["find"])?null:htmlspecialchars($_POST["find"],ENT_NOQUOTES,'UTF-8'));
$gname1=empty($_POST["find"])?null:htmlspecialchars($_POST["find"],ENT_NOQUOTES,'UTF-8');
$key_gname1="%".$gname1."%";
$key_gname="%".$gname."%";
$key=$_POST["find"];
$sql = null;
$row_cnt = 0;

$cnt=0;
$all_cnt=1;
$cnt_book=1;
//상세검색함수들

$sql = $dbh ->prepare( 'select B.BookNumber,Title,SubTitle,AName,PName,OptionNumber,MIN(BorrowFlag)as borrow
						from Book as B,Publishcompany as P,Author as A,Library as L
						where  B.PNumber=P.PNumber
						and B.ANumber=A.ANumber
						and B.BookNumber=L.BookNumber
						and (
						(LOWER(L.LibraryNumber) Like ?)
						or (LOWER(B.ISBN) Like ?)
						or (LOWER(B.Title) Like LOWER( ? ))
						or (LOWER(B.TitleKana) Like LOWER( ? ))
						or (LOWER(B.SubTitle) Like LOWER( ? ))
						or (LOWER(B.SubTitleKana) Like LOWER( ? ))
						or (LOWER(A.AName) Like LOWER( ? ))
						or (LOWER(A.ANameKana) Like LOWER( ? ))
						or (LOWER(P.PName) Like LOWER( ? ))
						or (LOWER(P.PNameKana) Like LOWER( ? ))
						)
						GROUP BY B.BookNumber,Title,SubTitle,AName,PName,OptionNumber');
$sql->execute(array($gname,$gname,$key_gname,$key_gname,$key_gname,$key_gname,$key_gname,$key_gname,$key_gname,$key_gname));
$row = $sql->fetch( PDO::FETCH_ASSOC);
if($gname_len!=0){
	if ($row != false) {
		while($row = $sql->fetch( PDO::FETCH_ASSOC)){
			$all_cnt++;
		}
		echo "<h2>[".$key."]の検索結果　全". $all_cnt."件</h2>";
		$cnt=$all_cnt;
		echo"<table class=\"result\" border=\"1\">";
		echo"<tr>";
		echo"<td><strong>番号</strong></td>";
		echo"<td><strong>署名(タイトル)</strong></td>";
		echo"<td><strong>副書名(サブタイトル)</strong></td>";
		echo"<td><strong>著者名</strong></td>";
		echo"<td><strong>出版社</strong></td>";
		echo"<td><strong>付属品</strong></td>";
		echo"<td><strong>貸し出し状態</strong></td>";
		echo"<td><strong>　</strong></td>";
		echo"</tr>";
		$sql->execute(array($gname,$gname,$key_gname,$key_gname,$key_gname,$key_gname,$key_gname,$key_gname,$key_gname,$key_gname));
		while($row = $sql->fetch( PDO::FETCH_ASSOC)){
			echo "<tr>\n";
			echo "<td>" . $cnt_book . "</td>\n";
			echo "<td>" . $row ["Title"] . "</td>\n";
			$subTitle=strlen($row ["SubTitle"]);
			if($subTitle == 0){
				echo "<td>なし</td>\n";
			}else{
				echo "<td>" .$row ["SubTitle"]. "</td>\n";
			}
			echo "<td>" . $row ["AName"] . "</td>\n";
			echo "<td>" . $row ["PName"] . "</td>\n";

			$option=strlen($row ["OptionNumber"]);
			if($option == 0){
				echo "<td>なし</td>\n";
			}else{
				echo "<td>あり</td>\n";
			}
			if($row ["borrow"]==0){
				echo "<td><strong>貸し出し可能</strong></td>\n";
			}else{
				echo "<td>貸し出し中 </td>\n";
			}
			$cnt_book++;
			echo "<td ><input type=\"button\" value=\"詳細\" onClick=\"document.location='./bookDetail.php?gid={$row['BookNumber']}'\"></td>\n";
			echo "</tr>\n";

		}
		echo"</table>";
	}
	if ($cnt==0){
	echo "<h2 style=\"color:red\">[".$gname1."]に一致する蔵書がありません。</h2>";
	}
}else{
	echo "<h2 style=\"color:red\">[ ".$gname1." ]に一致する蔵書がありません。</h2>";
}
echo"<input type=\"button\" value=\"戻る\" onClick=\"javascript:history.go(-1)\">\n";
$dbh = null;
?>
	</div>
</div>
</body>
</html>

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
	<h1><a href="http://localhost/newLibrarySystem/topMain.php" title="日本電子中央図書館"><span class="hidden">日本電子中央図書館</span></a></h1>
</div>

<div id='cssmenu'>
<ul>
   <li><a href='http://localhost/newLibrarySystem/topMain.php'><span>Home</span></a></li>
   <li class='active has-sub'><a href='http://localhost/newLibrarySystem/detailsSearch.php'><span>蔵書検索</span></a>
      <ul>
         <li class='has-sub'><a href='http://localhost/newLibrarySystem/detailsSearch.php'><span>詳細検索</span></a></li>
         <li class='has-sub'><a href='http://localhost/newLibrarySystem/newBookSearch.php'><span>新着資料検索</span></a></li>
      </ul>
   </li>
   <li class='active has-sub'><a href='http://localhost/newLibrarySystem/libraryInfo.php'><span>図書館案内</span></a>
      <ul>
         <li class='has-sub'><a href='http://localhost/newLibrarySystem/libraryInfo.php'><span>図書館案内</span></a></li>
         <li class='has-sub'><a href='http://localhost/newLibrarySystem/donationInfo.php'><span>資料寄贈案内</span></a></li>
      </ul>
   </li>
   <li><a href='http://localhost/newLibrarySystem/FQAInfo.php'><span>FAQ</span></a></li>
</ul>
</div>
<div id="container">
	<div id="main">
<?php
$gname1_len=strlen(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')));//text1
$gname2_len=strlen(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8')));//text2
$gname3_len=strlen(trim(empty($_POST["text3"])?null:htmlspecialchars($_POST["text3"],ENT_NOQUOTES,'UTF-8')));//text3
$all_cnt=1;
$cnt_book=1;
$today=getdate();
//상세검색함수들
$select1_sub=$_REQUEST['select1'];//상세검색 셀렉트 박스 1
switch($select1_sub){
	case"GName":
		$select1_sub='分類名';
		break;
	case "ISBN":
		$select1_sub='ISBN';
		break;
	case "Title":
		$select1_sub='書名(タイトル)';
		break;
	case "TitleKana":
		$select1_sub='書名(タイトル)よみがな';
		break;
	case "SubTitle":
		$select1_sub='副書名(サブタイトル)';
		break;
	case "SubTitleKana":
		$select1_sub='副書名(サブタイトル)よみがな';
		break;
	case "AName":
		$select1_sub='著者名';
		break;
	case "ANameKana":
		$select1_sub='著者名よみがな';
		break;
    case "PName":
    	$select1_sub='出版社';
    	break;
    case "PNameKana":
    	$select1_sub='出版社よみがな';
    	break;
}
$select2_sub=$_REQUEST['select2'];//상세검색 셀렉트 박스 2
switch($select2_sub){
	case"GName":
		$select2_sub='分類名';
		break;
	case "ISBN":
		$select2_sub='ISBN';
		break;
	case "Title":
		$select2_sub='書名(タイトル)';
		break;
	case "TitleKana":
		$select2_sub='書名(タイトル)よみがな';
		break;
	case "SubTitle":
		$select2_sub='副書名(サブタイトル)';
		break;
	case "SubTitleKana":
		$select2_sub='副書名(サブタイトル)よみがな';
		break;
	case "AName":
		$select2_sub='著者名';
		break;
	case "ANameKana":
		$select2_sub='著者名よみがな';
		break;
	case "PName":
		$select2_sub='出版社';
		break;
	case "PNameKana":
		$select2_sub='出版社よみがな';
		break;
}
$select3_sub=$_REQUEST['select3'];//상세검색 셀렉트 박스 3
switch($select3_sub){
	case"GName":
		$select3_sub='分類名';
		break;
	case "ISBN":
		$select3_sub='ISBN';
		break;
	case "Title":
		$select3_sub='書名(タイトル)';
		break;
	case "TitleKana":
		$select3_sub='書名(タイトル)よみがな';
		break;
	case "SubTitle":
		$select3_sub='副書名(サブタイトル)';
		break;
	case "SubTitleKana":
		$select3_sub='副書名(サブタイトル)よみがな';
		break;
	case "AName":
		$select3_sub='著者名';
		break;
	case "ANameKana":
		$select3_sub='著者名よみがな';
		break;
	case "PName":
		$select3_sub='出版社';
		break;
	case "PNameKana":
		$select3_sub='出版社よみがな';
		break;
}
if($gname1_len!=0&&$gname2_len==0&&$gname3_len==0){//1개 조건으로 검색합니다.
	$perfectDate=isset($_POST["allMatchDate"]);//전체기간 체크ture,false
	$perfectMatch1=isset($_POST["allMatch1"]);//체크ture,false
	$select1=$_REQUEST['select1'];//상세검색 셀렉트 박스 1
	$title=$select1_sub.":".(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')));
	//var_dump($select1);
	if ($perfectDate==true){//1개 검색 //전체기간 체크
		$startYear=$today['year']-11;
		//var_dump($startYear);
		$endYear=$today['year']+1;
		//var_dump($endYear);
		if($perfectMatch1==true){//전방일치
			$gname1=strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname1="%".strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')))."%";
		}
	}else{//1개 검색 //기간 선택
		$startYear=$_REQUEST['startYear'];//기간 시작
		$endYear=$_REQUEST['endYear'];//기간 끝
		if($perfectMatch1==true){//전방일치
			$gname1=strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')));
		}else{//부분일치
			$gname1="%".strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')))."%";
		}
	}
	$sql = $dbh ->prepare( 'select B.BookNumber,Title,SubTitle,AName,PName,OptionNumber,MIN(BorrowFlag)as borrow,G.GName
							from Book as B,Publishcompany as P,Author as A,Library as L,Genre as G
							where  B.PNumber=P.PNumber
							and G.GNumber=B.GNumber
							and B.ANumber=A.ANumber
							and B.BookNumber=L.BookNumber
							and ('.$select1.' like ?
							and PublishedYear BETWEEN ? AND ?
							)
							GROUP BY B.BookNumber,Title,SubTitle,AName,PName,OptionNumber,G.GName');
	$sql->execute(array($gname1,$startYear,$endYear));
}else if($gname1_len!=0&&$gname2_len!=0&&$gname3_len==0){//2개 검색
	$perfectDate=isset($_POST["allMatchDate"]);//전체기간 체크ture,false
	$select1=$_REQUEST['select1'];//상세검색 셀렉트 박스 1
	$select2=$_REQUEST['select2'];//상세검색 셀렉트 박스 2
	$select_choice1=$_REQUEST['selectCon1'];//상세검색 매치조건 1
	$title=$select1_sub.':'.(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8'))).'&#160;<strong>'.$select_choice1.'</strong>&#160;'.$select2_sub.':'.(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8')));
	$perfectMatch1=isset($_POST["allMatch1"]);//체크ture,false
	$perfectMatch2=isset($_POST["allMatch2"]);//ture,false
	if ($perfectDate==true){//2개 검색 //전체기간 체크
		$startYear=$today['year']-11;
		//var_dump($startYear);
		$endYear=$today['year']+1;
		//var_dump($endYear);
		if($perfectMatch1==true){
			$gname1=strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname1="%".strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')))."%";
		}
		if($perfectMatch2==true){
			$gname2=strtolower(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname2="%".strtolower(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8')))."%";
		}
	}else{//선택기간체크 안함
		$startYear=$_REQUEST['startYear'];//기간 시작
		$endYear=$_REQUEST['endYear'];//기간 끝
		if($perfectMatch1==true){
			$gname1=strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname1="%".strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')))."%";
		}
		if($perfectMatch2==true){
			$gname2=strtolower(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname2="%".strtolower(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8')))."%";
		}
	}
	$sql = $dbh ->prepare( 'select B.BookNumber,Title,SubTitle,AName,PName,OptionNumber,MIN(BorrowFlag)as borrow,G.GName
							from Book as B,Publishcompany as P,Author as A,Library as L,Genre as G
							where  B.PNumber=P.PNumber
							and G.GNumber=B.GNumber
							and B.ANumber=A.ANumber
							and B.BookNumber=L.BookNumber
							and ('.$select1.' like ?
							'.$select_choice1.' ('.$select2.' like ? )
							and PublishedYear BETWEEN ? AND ?
							)
							GROUP BY B.BookNumber,Title,SubTitle,AName,PName,OptionNumber,G.GName');
	$sql->execute(array($gname1,$gname2,$startYear,$endYear));
}else if($gname1_len!=0&&$gname2_len!=0&&$gname3_len!=0){//3 개 검색
	$select_choice1=$_REQUEST['selectCon1'];//상세검색 매치조건 1
	$select_choice2=$_REQUEST['selectCon2'];//상세검색 매치조건 2
	$select1=$_REQUEST['select1'];//상세검색 셀렉트 박스 1
	$select2=$_REQUEST['select2'];//상세검색 셀렉트 박스 2
	$select3=$_REQUEST['select3'];//상세검색 셀렉트 박스 3
	$perfectMatch1=isset($_POST["allMatch1"]);//체크ture,false
	$perfectMatch2=isset($_POST["allMatch2"]);//ture,false
	$perfectMatch3=isset($_POST["allMatch3"]);//ture,false
	$perfectDate=isset($_POST["allMatchDate"]);//전체기간 체크ture,false
	$title=$select1_sub.':'.(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8'))).'&#160;<strong>'.$select_choice1.'</strong>&#160;'.$select2_sub.':'.(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8'))).'&#160;<strong>'.$select_choice2.'</strong>&#160;'.$select3_sub.':'.(trim(empty($_POST["text3"])?null:htmlspecialchars($_POST["text3"],ENT_NOQUOTES,'UTF-8')));
	if ($perfectDate==true){//2개 검색 //전체기간 체크
		$startYear=$today['year']-11;
		//var_dump($startYear);
		$endYear=$today['year']+1;
		//var_dump($endYear);
		if($perfectMatch1==true){
			$gname1=strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname1="%".strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')))."%";
		}
		if($perfectMatch2==true){
			$gname2=strtolower(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname2="%".strtolower(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8')))."%";
		}
		if($perfectMatch3==true){
			$gname3=strtolower(trim(empty($_POST["text3"])?null:htmlspecialchars($_POST["text3"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname3="%".strtolower(trim(empty($_POST["text3"])?null:htmlspecialchars($_POST["text3"],ENT_NOQUOTES,'UTF-8')))."%";
		}
	}else{//선택기간체크 안함
		$startYear=$_REQUEST['startYear'];//기간 시작
		$endYear=$_REQUEST['endYear'];//기간 끝
		if($perfectMatch1==true){
			$gname1=strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname1="%".strtolower(trim(empty($_POST["text1"])?null:htmlspecialchars($_POST["text1"],ENT_NOQUOTES,'UTF-8')))."%";
		}
		if($perfectMatch2==true){
			$gname2=strtolower(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname2="%".strtolower(trim(empty($_POST["text2"])?null:htmlspecialchars($_POST["text2"],ENT_NOQUOTES,'UTF-8')))."%";
		}
		if($perfectMatch3==true){
			$gname3=strtolower(trim(empty($_POST["text3"])?null:htmlspecialchars($_POST["text3"],ENT_NOQUOTES,'UTF-8')));
		}else{
			$gname3="%".strtolower(trim(empty($_POST["text3"])?null:htmlspecialchars($_POST["text3"],ENT_NOQUOTES,'UTF-8')))."%";
		}
	}
	$sql = $dbh ->prepare( 'select B.BookNumber,Title,SubTitle,AName,PName,OptionNumber,MIN(BorrowFlag)as borrow,G.GName
							from Book as B,Publishcompany as P,Author as A,Library as L,Genre as G
							where  B.PNumber=P.PNumber
							and G.GNumber=B.GNumber
							and B.ANumber=A.ANumber
							and B.BookNumber=L.BookNumber
							and ('.$select1.' like ?
							'.$select_choice1.' ('.$select2.' like ? )
							'.$select_choice2.' ('.$select3.' like ? )
							and PublishedYear BETWEEN ? AND ?
							)
							GROUP BY B.BookNumber,Title,SubTitle,AName,PName,OptionNumber,G.GName');
	$sql->execute(array($gname1,$gname2,$gname3,$startYear,$endYear));
}
$row = $sql->fetch( PDO::FETCH_ASSOC);
if ($row != false) {
	while($row = $sql->fetch( PDO::FETCH_ASSOC)){
		$all_cnt++;
	}
	echo "<h2>[".$title."]の検索結果　全". $all_cnt."件</h2>";

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
	if($gname1_len!=0&&$gname2_len==0&&$gname3_len==0){
		$sql->execute(array($gname1,$startYear,$endYear));
	}else if($gname1_len!=0&&$gname2_len!=0&&$gname3_len==0){//2개 검색
		$sql->execute(array($gname1,$gname2,$startYear,$endYear));
	}else if($gname1_len!=0&&$gname2_len!=0&&$gname3_len!=0){//3 개 검색
		$sql->execute(array($gname1,$gname2,$gname3,$startYear,$endYear));
	}
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
if ($all_cnt==1){
echo "<h2 style=\"color:red\">[".$title."]に一致する蔵書がありません。</h2>";
}
echo"<input type=\"button\" value=\"戻る\" onClick=\"javascript:history.go(-1)\">\n";
$dbh = null;
?>
	</div>
</div>
</body>
</html>

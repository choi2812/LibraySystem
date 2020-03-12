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
   <title>日本電子中央図書館</title>
</head>
<body>
<script>
	function button1_click(number) {
		if(confirm("蔵書番号"+number+"延長しますか？")){
			location.href="./book_extension.php? booknumber=" + number;
		}
	}
</script>

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
$cnt=0;
$all_cnt=1;
$cnt_book=1;
$year = date('Y');
$month = date('m');
$day = date('d');
$yoil = array("日","月","火","水","木","金","土");
//echo date("Y-m-d", mktime( 0, 0, 0, $month, $day-7, $year ));//이전
//echo($yoil[date('w', strtotime(date("Y-m-d", mktime( 0, 0, 0, $month, $day-7, $year ))))])."<br>\n";
//echo date("Y-m-d",time());
//echo($yoil[date('w', strtotime(date("Y-m-d",time())))])."<br>\n";
//echo date("Y-m-d", mktime( 0, 0, 0, $month, $day+7, $year ));//이후
//echo($yoil[date('w', strtotime(date("Y-m-d", mktime( 0, 0, 0, $month, $day+7, $year ))))])."<br>\n";

$sql = $dbh ->prepare( 'select L.LibraryNumber,Title,AName,PName,OptionName,BorrowDate,ScheduleReturnDate,ExtensionFlag
						from Book as B,Publishcompany AS P,Author AS A,OptionType AS O ,Library AS L,Borrow AS BO
						where B.BookNumber=L.BookNumber
						and P.PNumber=B.PNumber
						and A.ANumber=B.ANumber
						and O.OptionNumber=B.OptionNumber
						and L.LibraryNumber=BO.LibraryNumber
						and UserNumber like ?
						GROUP BY L.LibraryNumber,Title,AName,PName,OptionName,BorrowDate,ScheduleReturnDate,ExtensionFlag');
$sql->execute(array($_SESSION['ses_userid']));
$row = $sql->fetch( PDO::FETCH_ASSOC);
if ($row != false) {
	while($row = $sql->fetch( PDO::FETCH_ASSOC)){
		$all_cnt++;
	}
	echo "<h2>".$_SESSION['ses_userid']."様の貸し出しリスト</h2>";
	$cnt=$all_cnt;
	echo"<table border=\"1\">";
	echo"<tr>";
	echo"<td><strong>番号</strong></td>";
	echo"<td><strong>蔵書番号</strong></td>";
	echo"<td><strong>署名(タイトル)</strong></td>";
	echo"<td><strong>著者名</strong></td>";
	echo"<td><strong>出版社</strong></td>";
	echo"<td><strong>付属品</strong></td>";
	echo"<td><strong>貸し出し日</strong></td>";
	echo"<td><strong>返却日</strong></td>";
	echo"<td><strong>返却予定日</strong></td>";
	echo"<td><strong>延長回数</strong></td>";
	echo"<td><strong>予約者有無</strong></td>";
	echo"<td><strong>貸し出し延長</strong></td>";

	echo"</tr>";
	$sql1 = $dbh ->prepare( 'select L.LibraryNumber,Title,AName,PName,OptionName,BorrowDate,ScheduleReturnDate,ExtensionFlag,ReturnDate
						from Book as B,Publishcompany AS P,Author AS A,OptionType AS O ,Library AS L,Borrow AS BO
						where B.BookNumber=L.BookNumber
						and P.PNumber=B.PNumber
						and A.ANumber=B.ANumber
						and O.OptionNumber=B.OptionNumber
						and L.LibraryNumber=BO.LibraryNumber
						and UserNumber like ?
						GROUP BY L.LibraryNumber,Title,AName,PName,OptionName,BorrowDate,ScheduleReturnDate,ExtensionFlag,ReturnDate
						ORDER BY ReturnDate ,ScheduleReturnDate');
	$sql1->execute(array($_SESSION['ses_userid']));
	while($row = $sql1->fetch( PDO::FETCH_ASSOC)){
		echo "<tr>\n";
		echo "<td>" . $cnt_book . "</td>\n";
		echo "<td>" . $row ["LibraryNumber"] . "</td>\n";
		$LibraryNumber=$row ["LibraryNumber"];
		echo "<td>" . $row ["Title"] . "</td>\n";
		echo "<td>" . $row ["AName"] . "</td>\n";
		echo "<td>" . $row ["PName"] . "</td>\n";
		echo "<td>" . $row ["OptionName"]. "</td>\n";
		echo "<td>" . $row ["BorrowDate"].($yoil[date('w', strtotime($row ["BorrowDate"]))]). "</td>\n";
		if($row ["ReturnDate"]==null){
			echo "<td>未返却</td>\n";
			echo "<td>" . $row ["ScheduleReturnDate"].($yoil[date('w', strtotime($row ["ScheduleReturnDate"]))]). "</td>\n";
			$ScheduleReturnDate=$row ["ScheduleReturnDate"];
			echo "<td>" . $row ["ExtensionFlag"]. "</td>\n";
			$ExtensionFlag=$row ["ExtensionFlag"];
			//$row=null;

			$sql = $dbh ->prepare( 'select BookingNumber from Booking
								where LibraryNumber like ? ');
			$sql->execute(array($LibraryNumber));
			//var_dump($LibraryNumber);
			$yoyaku=0;
			while($row2 = $sql->fetch( PDO::FETCH_ASSOC)){
				//var_dump($row);
				$yoyaku++;
			}
			if($yoyaku>0){
				echo "<td>".$yoyaku."</td>\n";
				echo "<td>予約者あり</td>\n";
			}else{
				echo "<td>".$yoyaku."</td>\n";
				if($ExtensionFlag==0){
					if(floor(( strtotime(date("Y-m-d",time())) - strtotime($ScheduleReturnDate) )/86400 <0)){
						echo "<td><input type=\"button\" value=\"貸し出し延長\" onclick=\"button1_click('".$row ["LibraryNumber"]."');\"></td>\n";
					} else{
						echo "<td>貸し出し期間超え</td>\n";
					}
				}else{
					echo "<td>延長回数超え</td>\n";
				}
			}

			$cnt_book++;
			//onClick=\"document.location='./bookDetail.php?gid={$row['BookNumber']}'\"
			echo "</tr>\n";
		}else{
			echo "<td>" . $row ["ReturnDate"].($yoil[date('w', strtotime($row ["ReturnDate"]))]). "</td>\n";
			echo "<td>　</td>\n";
			echo "<td>　</td>\n";
			echo "<td>　</td>\n";
			echo "<td><strong>返却完了</strong></td>\n";

		}
/*		echo "<td>" . $row ["ScheduleReturnDate"].($yoil[date('w', strtotime($row ["ScheduleReturnDate"]))]). "</td>\n";
		$ScheduleReturnDate=$row ["ScheduleReturnDate"];
		echo "<td>" . $row ["ExtensionFlag"]. "</td>\n";
		$ExtensionFlag=$row ["ExtensionFlag"];
		//$row=null;

		$sql = $dbh ->prepare( 'select BookingNumber from Booking
								where LibraryNumber like ? ');
		$sql->execute(array($LibraryNumber));
		//var_dump($LibraryNumber);
		$yoyaku=0;
			while($row2 = $sql->fetch( PDO::FETCH_ASSOC)){
				//var_dump($row);
				$yoyaku++;
			}
			if($yoyaku>0){
				echo "<td>".$yoyaku."</td>\n";
				echo "<td>予約者あり</td>\n";
			}else{
				echo "<td>".$yoyaku."</td>\n";
				if($ExtensionFlag==0){
					if(floor(( strtotime(date("Y-m-d",time())) - strtotime($ScheduleReturnDate) )/86400 <0)){
						echo "<td><input type=\"button\" value=\"貸し出し延長\" onclick=\"button1_click('".$row ["LibraryNumber"]."');\"></td>\n";
					} else{
						echo "<td>貸し出し期間超え</td>\n";
					}
				}else{
					echo "<td>延長回数超え</td>\n";
				}
			}

		$cnt_book++;
		//onClick=\"document.location='./bookDetail.php?gid={$row['BookNumber']}'\"
		echo "</tr>\n";
*/
	}
	echo"</table>";
}
if ($cnt==0){
echo "<h2>".$_SESSION['ses_userid']."様の貸し出しリスト</h2>";
echo "<h3 style=\"color:red\">貸し出し中の蔵書が存在しません。</h3>";
}
echo"<input type=\"button\" value=\"戻る\" onClick=\"javascript:history.go(-1)\">\n";
$dbh = null;
?>

	</div>
</div>
</body>
</html>
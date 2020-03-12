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
function chk_search(){
	if($.trim(details_form.text1.value)==""&&$.trim(details_form.text2.value)==""&&$.trim(details_form.text3.value)==""){
		details_form.text1.focus();
		alert('検索語を入力してください。');
		return false;
	}else if($.trim(details_form.text1.value)==""&&$.trim(details_form.text2.value)!=""&&$.trim(details_form.text3.value)!=""){
		details_form.text1.focus();
		alert('検索条件は上から順番に埋めてください。');
		return false;
	}else if($.trim(details_form.text1.value)!=""&&$.trim(details_form.text2.value)==""&&$.trim(details_form.text3.value)!=""){
		details_form.text1.focus();
		alert('検索条件は上から順番に埋めてください。');
		return false;
	}else if($.trim(details_form.text1.value)==""&&details_form.text2.value==""&&details_form.text3.value!=""){
		details_form.text1.focus();
		alert('検索条件は上から順番に埋めてください。');
		return false;
	}else if(details_form.text1.value==""&&details_form.text2.value!=""&&details_form.text3.value==""){
		details_form.text1.focus();
		alert('検索条件は上から順番に埋めてください。');
		return false;
	}else{
		return true;
	}
}

</script>
<form name="details_form" method="post" onsubmit="return chk_search();" action="selectBook2.php">
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
				<h2>詳細検索</h2>
				<p>
					<select name="select1">
						<option value="GName" selected>分類名</option>
						<option value="ISBN">ISBN</option>
						<option value="Title">書名(タイトル)</option>
						<option value="TitleKana">書名(タイトル)よみがな</option>
						<option value="SubTitle">副書名(サブタイトル)</option>
						<option value="SubTitleKana">副書名(サブタイトル)よみがな</option>
						<option value="AName">著者名</option>
						<option value="ANameKana">著者名よみがな</option>
						<option value="PName">出版社</option>
						<option value="PNameKana">出版社よみがな</option>
					</select>
					<input type="text" name="text1" size="60">
					<input type="checkbox" name="allMatch1" value="完全一致">完全一致
					&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;
					<select name="selectCon1">
						<option value="AND">○○　と　○○ </option>
						<option value="OR">○○　又は　○○</option>
					</select>
				</p>
				<p>
					<select name="select2">
						<option value="GName">分類名</option>
						<option value="ISBN">ISBN</option>
						<option value="Title" selected>書名(タイトル)</option>
						<option value="TitleKana">書名(タイトル)よみがな</option>
						<option value="SubTitle">副書名(サブタイトル)</option>
						<option value="SubTitleKana">副書名(サブタイトル)よみがな</option>
						<option value="AName">著者名</option>
						<option value="ANameKana">著者名よみがな</option>
						<option value="PName">出版社</option>
						<option value="PNameKana">出版社よみがな</option>
					</select>
					<input type="text" name="text2" size="60">
					<input type="checkbox" name="allMatch2" value="完全一致">完全一致
					&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;
					<select name="selectCon2">
						<option value="AND">○○　と　○○ </option>
						<option value="OR">○○　又は　○○</option>
					</select>
				</p>
				<p>
					<select name="select3">
						<option value="GName">分類名</option>
						<option value="ISBN">ISBN</option>
						<option value="Title">書名(タイトル)</option>
						<option value="TitleKana">書名(タイトル)よみがな</option>
						<option value="SubTitle">副書名(サブタイトル)</option>
						<option value="SubTitleKana">副書名(サブタイトル)よみがな</option>
						<option value="AName">著者名</option>
						<option value="ANameKana">著者名よみがな</option>
						<option value="PName" selected>出版社</option>
						<option value="PNameKana">出版社よみがな</option>
					</select>
					<input type="text" name="text3" size="60">
					<input type="checkbox" name="allMatch3" value="完全一致">完全一致
					&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;
					&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;
					&#160;&#160;&#160;&#160;&#160;&#160;&#160;

				</p>
				<p><font size=4 color=red>※検索は上の検索語から埋めてください。</font></p>
				<p>発行年
			<?php
			$year=0;
			$today=getdate();
			echo '<select name="startYear">';
			for($Syear=$today['year']-11; $Syear < $today['year']+1 ; $Syear ++){
				echo '<option value="'.$Syear.'">'.$Syear.'</option>';
			}
			echo '</select>';
			echo '&#160;&#160;-&#160;&#160;';
			echo '<select name="endYear">';
			for($Eyear=$today['year']; $Eyear+1 > $today['year']-11 ; $Eyear --){
				echo '<option value="'.$Eyear.'">'.$Eyear.'</option>';
			}
			echo '</select>';
			?>
			<input type="checkbox" name="allMatchDate" value="すべての期間">すべての期間
				</p>
			<p><input type="submit" value="検索">&#160;&#160;&#160;&#160;<input type="reset" value="リセット" ></p>
		</div>
	</div>
</form>
</body>
</html>
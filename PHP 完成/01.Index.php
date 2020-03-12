
 <!DOCTYPE html>
<html lang="ja">
<head>
<meta charset="UTF-8">
<title>HTMLの練習_リスト</title>
</head>
<body>
<?php
$pageName=array(
        'topMain.php',
        'topMain_login.php',
        'logout.php',
        'db_connect.php',
        'db_info.php',
        'passTransForm.php',
        'pass_check.php',
        'passConfirm.php',
        'passTransComplete.php',
        'login.php',
        'login_judge.php',
        'borrowList.php',
        'book_extension.php',
        'rservationList.php',
        'rservation_Cancel.php',
        'detailsSearch.php',
        'newBookSearch.php',
        'selectBook.php',
        'selectBook2.php',
        'selectBook3.php',
        'bookDetail.php',
        'yoyaku.php',
        'libraryInfo.php',
        'donationInfo.php',
        'FQAInfo.php',
);

$pageLine=array(
                '未ログイントップページ',
                'ログイン済みトップページ',
                'ログアウト機能',
                'デ－タベ－スに接続機能',
                'デ－タベ－スの情報機能',
                '01．パスワード変更フォーム',
                '01-1．パスワード変更内容チェックの機能',
                '02．パスワード変更内容確認ページ',
                '03．パスワード変更完了ページ+メールを送る機能',
                '中途ログインページ＋エラー',
                'ログイン情報確認機能',
                '個人アカウントの貸し出しリストページ',
                '貸し出しの延長機能',
                '個人アカウントの予約貸し出しリストページ',
                '予約貸し出し取り消し機能',
                '詳細検索ページ＋エラー',
                '新着資料検索ページ',
                '簡易検索の一覧ページ',
                '詳細検索の一覧ページ',
                '新着・削除予定資料の一覧ページ',
                '蔵書1冊の詳細ページ',
                '蔵書予約機能',
                '図書館案内',
                '資料寄贈案内',
                'FAQ一覧',
);
?>
        <table border="1">
                        <tr>
                                <th>ページ番号</th>
                                <th>ページの内容</th>
                                <th>ページの名前</th>
                        </tr>
                        <?php
                        for($i=0;$i<25;$i++){
                                echo "<tr>";
                                echo "<td>".$i."</td>";
                                echo "<td>".$pageLine[$i]."</td>";
                                echo "<td><a href=\"./$pageName[$i]\">".$pageName[$i]."</a></td>";
                                echo "</tr>";
                        }
                        ?>
        </table>
</body>
</html>
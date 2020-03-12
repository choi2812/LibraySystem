<?php
session_start();
?>
<!DOCTYPE html>
<html lang=ja>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<title>セッションを破棄する</title>
</head>
<body>
<table>
<?php
$_SESSION= array();
session_destroy();
header('Location: ./topMain.php');

?>
</table>
</body>
</html>

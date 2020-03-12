<?php
try {
	require_once 'db_info.php';
	$dbh = new PDO ( DB_SERVER, USER_NAME, PASS );
	$dbh ->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
} catch ( PDOException $e ) {
	print "接続エラー!: " . $e->getMessage () . "<br/>";
	die ();
}

?>
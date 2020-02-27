<?

require 'eRequest.php';

$eRequest = new eRequest('EncryptionKey');
$arr['charlie'] = 'Custom Data From Server';
$arr['key'] = $_POST['key'];
$eRequest->output(true, 'Reply', $arr);

?>
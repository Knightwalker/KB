<?php

$country = readline();
$language = "";

if ($country == "USA" || $country == "England") { $language = "English"; } 
else if ($country == "Spain" || $country == "Argentina" || $country == "Mexico") { $language = "Spanish"; } 
else { $language = "unknown"; }

echo $language;

?>
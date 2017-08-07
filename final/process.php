//Post variables

//Get the src and image details from table.
$src = $row['src-in-db'];
$alt = $row['alt-in-db'];
$width = $row['width-in-db'];
$height = $row['height-in-db'];
//Echo the html code for #gallery-overlay.

    echo "<img src='".$src."' width='".$width."' height='".$height."' alt='".$alt."'>";
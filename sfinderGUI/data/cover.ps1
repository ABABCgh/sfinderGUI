$input = Get-Content .\input.txt
$select = Get-Content .\select.txt
$sf = Get-Content ..\readme.txt
cd $sf[0]
$fumens = ""
@($select) -is [Array]
for($i = 0; $i -lt @($select).Length; $i++)
{
  $fumens += @($select)[$i] + " "
}
$p2 = $input[3]
$mode = $input[6]
$drop = $input[8]
java -jar sfinder.jar cover -t $fumens -p $p2 -M $mode -d $drop

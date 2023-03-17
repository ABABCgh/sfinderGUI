$input = Get-Content .\input.txt
$cd = Convert-Path .
$sf = Get-Content ..\readme.txt
cd $sf[0]
$tetfu = $input[0]
$page = $input[1]
$p1 = $input[2]
java -jar sfinder.jar setup -t $tetfu -f I -s yes -fo csv -P $page -p $p1
$fumens = Select-String -Path output\setup.csv -Pattern "v115@[a-zA-z0-9+/?]+" -AllMatches -Encoding default | %{$_.Matches} | %{$_.Value }| % -Begin {$str=@()} {$str+=$_} -End{$str}
cd $cd
Clear-Content .\result.txt
Clear-Content .\select.txt
foreach ($fumen in $str)
{
  echo $fumen >> .\result.txt
  echo $fumen >> .\select.txt
}
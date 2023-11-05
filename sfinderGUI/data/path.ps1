$input = Get-Content .\input.txt
$cd = Convert-Path .
$sf = Get-Content ..\readme.txt
cd $sf[0]
$tetfu = $input[0]
$page = $input[1]
$p1 = $input[2]
$height = $input[5]
java -jar sfinder.jar path -t $tetfu -f link -s yes -P $page -p $p1 -c $height
$fumens = Select-String -Path output\path_unique.html -Pattern "v115@[a-zA-z0-9+/?]+" -AllMatches -Encoding default | %{$_.Matches} | %{$_.Value }| % -Begin {$str=@()} {$str+=$_} -End{$str}
cd $cd
Clear-Content .\result.txt
Clear-Content .\select.txt
foreach ($fumen in $str)
{
  echo $fumen >> .\result.txt
  echo $fumen >> .\select.txt
}
$data1=Get-Content .\result.txt
$data2=Get-Content .\select.txt
$data1[0] = $null
$data2[0] = $null
$data1 | Out-File .\result.txt -Encoding UTF8
$data2 | Out-File .\select.txt -Encoding UTF8
Start-Sleep -s 1
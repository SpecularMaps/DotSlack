echo off

if not exist .\Dispatchers ( mklink /J Dispatchers ..\DotSlack.Shared\Dispatchers )

if not exist .\Models ( mklink /J Models ..\DotSlack.Shared\Models )

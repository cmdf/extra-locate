Get or set Cursor location in Windows Console.
> 1. Download [exe file](https://github.com/cmdf/extra-locate/releases/download/1.0.0/elocate.exe).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
> elocate [[+|-]<x>] [[+|-]<y>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: get current cursor location as "<x> <y>"
> elocate

:: set cursor location to start of line
> elocate 0

:: set cursor location to top-left corner
> elocate 0 0

:: set cursor location to x=10, y=20
> elocate 10 20

:: set cursor location to x=0, y=y+10
> elocate 0 +10

:: set cursor to go back to previous line start
> elocate o -1
```


[![cmdf](https://i.imgur.com/iliPFzH.jpg)](https://cmdf.github.io)

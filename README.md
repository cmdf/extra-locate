# olocate

Get or set Cursor location in Windows Console.


## usage

```batch
> olocate [[+|-]<x>] [[+|-]<y>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: get current cursor location as "<x> <y>"
> olocate

:: set cursor location to start of line
> olocate 0

:: set cursor location to top-left corner
> olocate 0 0

:: set cursor location to x=10, y=20
> olocate 10 20

:: set cursor location to x=0, y=y+10
> olocate 0 +10

:: set cursor to go back to previous line start
> olocate o -1
```


## license

Do you have a Poké ball? That's enough!

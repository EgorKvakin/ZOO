   M S B A M L   `   `   `  ????B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5          WpfApp5.Page1   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp5     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? Title$  Provider??5
      .??5      ? ???#004D47.+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ providerGrid??5         AutoGenerateColumns$ False??6O   $	??470??6k   $
??auto??6x   $??
0,-110,0,0q?6?   ??6+   ??  ?? Mode$ OneWay=?   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Фирма??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   ??  ?? Path$ 	firm_name?6f     5      $ Имя??6%   $
 auto 6Q    62   ?? $
 name?6`     5      $ Фамилия??6%   $
 auto 6W    66   ?? $ surname?6f     5      $ Адресс??6%   $
 auto 6Z    65   ?? $ firm_addres?6i     5      $! Номер телефона??6%   $
 auto 6g    6=   ?? $ telephone_number?6v   5      ?? 5   
   -   5        	 ??Name$		 Add??5   L   ???#128277$	??170??6&   $??40??62   
 ? Cursor$

 Hand??6>   $??40,514,290,30q?6Y   .??5      ??  ?? Orientation$ 
Horizontal=?6   $	??130??62   .+?5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$	 Add=?6*   $??25??65   $??25??6@   $??Center=?6L   ?? 5      ???#F9F9FF$??18(?61   ?? 6@   $?Добавить??6D   6W   5      5      ?? 5   
   -   5        $	 Delete??5   L   ???#128277$	??170??6&   $??40??62   $

 Hand??6>   $??290,514,40,30q?6\   .??5      ?? $ 
Horizontal=?6   $	??130??62   .+?5        $ Delete=?6*   $??25??68   $??25??6C   $??Center=?6O   ?? 5      ???#F9F9FF$??18(?61   ?? 6@   $?Удалить??6D   6V   5       5!      ?? 5#   
   -   5        $	 Update??5#   L   ???#128277$	??170??6&   $??40??62   $

 Hand??6>   $??165,624,165,20q?6\   .??5$      ?? $ 
Horizontal=?6   $	??130??62   .+?5%        $ Exchange=?6*   $??25??6:   $??25??6E   $??Center=?6Q   ?? 5&      ???#F9F9FF$??18(?61   ?? 6@   $?Изменить??6D   6W   5'      5(      5)      5*      
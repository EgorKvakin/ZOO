   M S B A M L   `   `   `  ????B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5   	       WpfApp5.Window3   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp5     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? Title$  Поставки??5	   	   $	??800??6   $
??1000??6'   .??5
      ? ???#004D47.+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
supplyGrid??5         AutoGenerateColumns$ False??6M   $	??470??6i   $	??900??6v   $??
0,-110,0,0q?6?   ??6)   ??  ?? Mode$ OneWay=?   Columns 5      4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        Provider??,  &System.Windows.Controls.DataGridColumn   Header$ Поставщик??5   <      DisplayMemberPath$ 	firm_name??6O      SelectedValuePath$ id??6?      SelectedValueBinding 6m   ?? 	 ?? Path$	 
providerid?6?     5      -   5        Product??$ Продукт??5   ;   $
 Name??6L   $ id??6?    6e   ?? $	 
productsid?6?   0  *System.Windows.Controls.DataGridTextColumn  5      $ Дата поставки??6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ?? $	 supply_date?6o     5      $ Колличество??6%   $	
 150 6Y    6:   ?? $	 kolvo?6g     5      $ Цена??6%   $	
 140 6R    63   ?? $	 price?6`   5      ?? 5   
   -   5         ??Name$	 Add??5   L   ???#128277$	??170??6&   $??40??62    ? Cursor$
 Hand??6>   $??195,564,635,80q?6Y   .??5      ??  ?? Orientation$ 
Horizontal=?6   $	??130??62   .+?5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$	 Add=?6*   $??25??65   $??25??6@   $??Center=?6L   ?? 5      ???#F9F9FF$??18(?61   ?? 6@   $?Добавить??6D   6W   5      5      ?? 5   
   -   5        $ Delete??5   L   ???#128277$	??170??6&   $??40??62   $
 Hand??6>   $??635,564,195,80q?6\   .??5      ?? $ 
Horizontal=?6   $	??130??62   .+?5        $ Delete=?6*   $??25??68   $??25??6C   $??Center=?6O   ?? 5      ???#F9F9FF$??18(?61   ?? 6@   $?Удалить??6D   6V   5      5      ?? 5!   
   -   5        $ Update??5!   L   ???#128277$	??170??6&   $??40??62   $
 Hand??6>   $??420,564,410,80q?6\   .??5"      ?? $ 
Horizontal=?6   $	??130??62   .+?5#        $ Exchange=?6*   $??25??6:   $??25??6E   $??Center=?6Q   ?? 5$      ???#F9F9FF$??18(?61   ?? 6@   $?Изменить??6D   6W   5%      5&      ?? 5'   
   -   5        $ NextPage??5'   L   ???#128277$	??170??6&   $??40??62   $
 Hand??6>   $??420,654,410,40q?6^   .??5(      ?? $ 
Horizontal=?6   $	??130??62   .+?5)        $ DeliveryDining=?6*   $??25??6@   $??25??6K   $??Center=?6W   ?? 5*      ???#F9F9FF$??18(?61   ?? 6@   $?Поставщик??6D   6X   5+      5,      5-      5.      
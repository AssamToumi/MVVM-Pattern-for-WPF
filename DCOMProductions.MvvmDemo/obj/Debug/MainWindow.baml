   M S B A M L   `   `   `  ����S  ODCOMProductions.MvvmDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:DCOMProductions.MvvmDemoDCOMProductions.MvvmDemo  5   	   )    #DCOMProductions.MvvmDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:DCOMProductions.MvvmDemo     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      � $	��Top=�6   $��16q�6#    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Customer Name:��6    �� 5   
   $��1��6   ��6"   �� *Customer.Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . �� 5   
   $��2��6   $��Update��6"   ��63   �� *UpdateCommand+5      5      
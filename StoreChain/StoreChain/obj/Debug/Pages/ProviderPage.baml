   M S B A M L   `   `   `  ����E  AStoreChain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StoreChain.PagesStoreChain.Pages  5      #    StoreChain.Pages.ProviderPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:StoreChain.Pages     5      -   5          N� Title$  ProviderPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.5* �6   6,   �� 5      $��2* �6   6*   �� 5      $
��0.5* �6   6,   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
providerdg��5      $��1��5         AutoGenerateColumns .     
IsReadOnly .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *ID+  5      $ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 5   %    5   %   �� *Name+  5      $ 
Адрес��6%   $
 0.5* 5   %    5   %   �� *	Address+  5      $ Телефон��6%   $
 0.5* 5   %    5    %   �� *Phone+5"      �� 5#   
   -   5        	 ��Name$	 	insertbtn��5#      $��Добавить��5$      $	��200��5%      $��30��5&      $��2��5'      $��Center=�5(      61   �� 5)   
   -   5        $	 backbtn��5)      $��
Назад��5*      $	��200��5+      $��30��5,      $��0��5-      $
��Left=�5.      $��20q�5/      6    �� 50   
   -   5        $	 	updatebtn��50      $��2��51      $	��200��52      $��30��53      $ ��Редактировать��54      $
��Left=�55      $��20q�56      6    �� 57   
   -   5        $	 	deletebtn��57      $��Удалить��58      $��30��59      $	��200��5:      $��Right=�5;      $��20q�5<      $��2��5=      6!   �� 5>   
   $��Поиск:��6   $��20(�5?      $��Center=�5@      $��Center=�5A      $��	30 15 0 0q�5B      �� 5C   
   -   5        
 ��Name$
 search��5C      $��40��5D      $	��300��5E      $��Right=�5F      $��20q�5G      6    5H      5I      
   M S B A M L   `   `   `  ����E  AStoreChain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StoreChain.PagesStoreChain.Pages  5           StoreChain.Pages.StorePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:StoreChain.Pages     5      -   5          N� Title$  	StorePage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.5* �6   6,   �� 5      $��2* �6   6*   �� 5      $
��0.5* �6   6,   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ storedg��5      $��1��5         AutoGenerateColumns .     
IsReadOnly .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *ID+  5      $ Название��6%    5   %   �� *NAME+  5      $ Профиль��6%    5   %   �� *	Profile+  5      $ Телефон��6%    5   %   �� *Phone+  5      $ Капитал��6%    5   %   �� *	Capital+  5       $' !Номер регистрации��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.9* 5!   %    5"   %   �� *NumberOfRegistration+  5#      $% Дата регистрации��6%   $
 0.9* 5$   %    5%   %   �� *DateOfRegistration+  5&      $ 
Вклад��6%    5'   %   �� *Contribution+  5(      $ Владелец��6%    5)   %   �� *
Owner.Name+5+      �� 5,   
   -   5        	 ��Name$	 	insertbtn��5,      $��Добавить��5-      $	��200��5.      $��30��5/      $��2��50      $��Center=�51      61   �� 52   
   -   5        $	 backbtn��52      $��
Назад��53      $	��200��54      $��30��55      $��0��56      $
��Left=�57      $��20q�58      6    �� 59   
   -   5        $	 	updatebtn��59      $��2��5:      $	��200��5;      $��30��5<      $ ��Редактировать��5=      $
��Left=�5>      $��20q�5?      6    �� 5@   
   -   5        $	 	deletebtn��5@      $��Удалить��5A      $��30��5B      $	��200��5C      $��Right=�5D      $��20q�5E      $��2��5F      6!   �� 5G   
   $��Поиск:��6   $��20(�5H      $��Center=�5I      $��Center=�5J      $��	30 15 0 0q�5K      �� 5L   
   -   5        
 ��Name$
 search��5L      $��40��5M      $	��300��5N      $��Right=�5O      $��20q�5P      6    5Q      5R      
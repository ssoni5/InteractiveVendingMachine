   M S B A M L   `   `   `  ����T  PInteractiveVendingMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:InteractiveVendingMachineInteractiveVendingMachine  5   	   *    $InteractiveVendingMachine.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:InteractiveVendingMachine     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ btnDepositQuarter��5
      $��Deposit Quarter��6,   $
��Left=�6F   $��	28,55,0,0q�6a   $	��Top=�6t   $	��127��6�   $��30��6�   6�   �� 5   
   -   5         ��Name$ imgAlmondJoy��5      $��Images/AlmondJoy.jpg��6'   $
��Left=�6E   $��56��6`   $��
18,178,0,0q�6l   $	��Top=�6�   $	��169��6�   �� 5   
   -   5        $ imgButterfinger��5      $��Images/Butterfinger.jpg��6)   $
��Left=�6J   $��48��6e   $��212,178,0,0q�6q   $	��Top=�6�   $	��189��6�   �� 5   
   -   5        $ imgTwix��5      $��Images/Twix.jpg��6!   $
��Left=�6:   $��54��6U   $��436,172,0,0q�6a   $	��Top=�6v   $	��151��6�   �� 5   
   -   5        $ imgSnickers��5      $��Images/Snickers.jpg��6%   $
��Left=�6B   $��48��6]   $��606,178,0,0q�6i   $	��Top=�6~   $	��163��6�   �� 5   
   -   5         ��Name$ 
lblHeading��5      $��Candy Vending Machine��6$   $
��Left=�6D   $��
296,10,0,0q�6_   $	��Top=�6s   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $ btnGetAlmondJoy��5      $��Get AlmondJoy��6*   $
��Left=�6B   $��
51,286,0,0q�6]   $	��Top=�6q   $	��104��6�   $��29��6�   6�   �� 5   
   -   5        $ btnButterfinger��5      $��Get Butterfinger��6*   $
��Left=�6E   $��260,286,0,0q�6`   $	��Top=�6u   $	��111��6�   $��29��6�   6�   �� 5   
   -	   5        $ btnTwix��5      $��Get Twix��6"   $
��Left=�65   $��477,286,0,105q�6P   $��75��6g   6r   �� 5   
   -
   5        $ btnSnickers��5      $��Get Snickers��6&   $
��Left=�6=   $��652,286,0,0q�6X   $	��Top=�6m   $��87��6�   $��29��6�   6�   �� 5   
   -   5         ��Name$ txtAlmondJoyCount��5      $
��Left=�6-   $��23��6H   $��
51,239,0,0q�6T    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ txtButterfingerCount��5      $
��Left=�60   $��23��6K   $��260,239,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ txtTwixCount��5      $
��Left=�6(   $��23��6C   $��453,239,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ txtSnickersCount��5      $
��Left=�6,   $��23��6G   $��639,239,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ lblTotalBars��5      $�� ��6&   $
��Left=�61   $��
488,55,0,0q�6L   $	��Top=�6`   $	��114��6x   �� 5   
   -   5        $ lblTotalMoney��5      $�� ��6'   $
��Left=�62   $��
627,55,0,0q�6M   $	��Top=�6a   $	��132��6y   �� 5   
   -   5        $ lblQuarterDeposited��5      $�� ��6-   $
��Left=�68   $��
179,59,0,0q�6S   $	��Top=�6g   $��77��6   �� 5   
   -   5        $ lblMessageOutput��5      $�� ��6*   $
��Left=�65   $��266,363,0,0q�6P   $	��Top=�6e   $	��236��6}   $
��Bold"�6�   5      5      
# BindingModes_IPNC

## Demo af Modes
Pr�v at �ndre `PieName` og `Price` og klik p� knappen. Kun `PieName` kan �ndres fordi `Mode="TwoWay"` default og `Price` er sat til `Mode="OneWay"`.

&nbsp;

## Demo af manglende ChangeNotification
Klik p� knappen og se at Price godt nok �ndrer sig i modellen, men at det ikke synkroniseres ud p� UI.

&nbsp;

## Demo af ChangeNotification
Udskift Pie modellen med en klasse, der har INPC eller ChangeNotification.

Klik p� knappen og se at Price nu synkroniseres ud p� UI.

![Data Binding Uden I P N C](images/DataBindingUdenIPNC.png)

&nbsp;
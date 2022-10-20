# Binding Single Object

### #1 Binding direct to Single Object
Her er hele Page.BindingContext sat til Pie-objektet: `this.BindingContext = Pie;`

I ContentPage skal datatypen s�ttes: `x:DataType="model:Pie"`

I Pagen kan man derfor lave en direkte binding: `Source="{Binding ImageUrl}"`

&nbsp;

### #2 Binding via Page and Property to Single object
Her er hele Page.BindingContext sat til hele Page-objektet: `this.BindingContext = this;`

Det betyder at f�lgende skal rettes i ContentPage: `x:DataType="local:MainPage"`

I Pagen skal man desuden have et ekstra niveau med i binding: `Source="{Binding Pie.ImageUrl}"`

&nbsp;

### #3 Binding via ViewModel to Single object and property
Page.BindingContext er nu �ndret til PieDetailViewModel-objektet: `this.BindingContext = this;`

Og ContentPage benytter nu: `x:DataType="vm:PieDetailViewModel"`

I Pagen skal man stadig f�rst tilg� Pie-objektet i binding: `Source="{Binding Pie.ImageUrl}"`. `UserName` kan man Binde direkte til.

&nbsp;
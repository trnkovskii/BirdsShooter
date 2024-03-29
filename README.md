1. **Oпис на апликацијата**

Целта на оваа апликација е создавање на играта **Birds Shooter**. Идејата на играта е во пукањето на што повеќе птици, а притоа избегнување на бомбите кои во спротивно даваат негативни поени. Со цел да обезбедам поголемо задоволство кај играчот, имплементирав три нивоа на тежина на кои може да се игра, секое со соодветни потешкотии да се достигне што подобар резултат. Времетраењето на играта е 1 и пол минута, но тоа се намалува доколку не погодиме некоја птица. Кога погодуваме птица се намалува преостанатото време за играње. Дизајнот на самата игра е  направен да играчот може лесно да стаса до посакуваната информација (старт на играта, прикажување на листа на најдобри поени, упатство на играта и сл.).

1. **Упатство за користење**

**2.1 Нова игра**

Почетното мени (сл.1) што се стартува при стартување на играта е со интересен дизајн, кој овозможува стартување на играта **(Click to play)**, пристап до упатството со правила за игра **(How to play)**, прикажување на листата на најдобри резултати **(Best players)**, одбирање на нивото за играта **(Difficulty)** и излез од игра **(Exit game)**. Доколку сакаме да стартуваме нова игра, прво треба да ја избереме едно од трите нивоа на тежина: Easy, Medium и Hard, инаку по дифолт е Easy .

 ![](https://scontent.fskp4-2.fna.fbcdn.net/v/t39.30808-6/273300162_4698649016929309_923042050528278420_n.jpg?_nc_cat=109&ccb=1-6&_nc_sid=0debeb&_nc_ohc=SVyAg04zndAAX91h706&tn=4tpyp--dBprw0Xg2&_nc_ht=scontent.fskp4-2.fna&oh=00_AT9CMRRQuV1hv-VwvycQe9VbiJrr9JOILKf6pn9CieCz4g&oe=628761E0)
Сл. 1

**2.2 Hоw to play**

Во оваа форма (Сл.2) се чува упатството кое ги содржи правилата на играта.

 ![](https://scontent.fskp4-2.fna.fbcdn.net/v/t39.30808-6/273405945_4698648986929312_7467524427234723876_n.jpg?_nc_cat=106&ccb=1-6&_nc_sid=0debeb&_nc_ohc=zHGx_aEu11wAX8Kgtqz&_nc_ht=scontent.fskp4-2.fna&oh=00_AT-c67fCw8sLzp9Mqka4oGU3CptjVbpioaEeBUZPguGSfw&oe=62871B06)














Сл. 2

**2.3 High scores**

Во овој дел (Сл.3) се чува листа на најдобри поени, подредени по опаѓачки редослед.

 ![](https://scontent.fskp4-1.fna.fbcdn.net/v/t39.30808-6/273453781_4698648963595981_8900420813011449978_n.jpg?_nc_cat=102&ccb=1-6&_nc_sid=0debeb&_nc_ohc=K0vAGVjJml0AX_PA_e-&_nc_ht=scontent.fskp4-1.fna&oh=00_AT-9haEW37KdTjHJp9VyYA6w9hOpbMomzDPBylEIqycufA&oe=62870B45)
Сл. 3

**2.4 Игра**

На сл.4 е прикажана интерфејсот на самата игра. Во горниот лев агол постојат копчиња за паузирање на играта и нејзино продолжување, како и за прекинување на играта. На десната страна е сместено преостатаното време, кое се намалува со секоја неубиена птица.

 ![](https://scontent.fskp4-1.fna.fbcdn.net/v/t39.30808-6/273200741_4698649026929308_4284239102499651125_n.jpg?_nc_cat=102&ccb=1-6&_nc_sid=0debeb&_nc_ohc=UxAjUsorJgwAX_eagcZ&tn=4tpyp--dBprw0Xg2&_nc_ht=scontent.fskp4-1.fna&oh=00_AT-ccbbp0maDiBDFizuVUwWa4gFJJ9sFqyPe6nBk6NyFkA&oe=62869119)




Сл. 4

**2.5 Congratulations**

По истекувањето на времето се појавува форма **Congratulations** , во која се напишани вкупниот број на освоени поени. Во неа се бара од играчот да го напише неговото име, за да биде ставено во листата на најдобри играчи.

 ![](https://scontent.fskg1-1.fna.fbcdn.net/v/t1.0-9/65393083_2107435499384020_3475309707097276416_n.jpg?_nc_cat=103&_nc_oc=AQnjh5jH8fEY2wm5CwwDxXpZwbCz6fSw9gnOAuq9Tw_1W0JVO4g1Uz_RgzSJKknMeJA&_nc_ht=scontent.fskg1-1.fna&oh=4944c490458dd446c883aa46971b5a31&oe=5D80A017)
1. **Претставување на проблемот**

**3.1 Податочни структури и функции**

Главните податоци и функции за играта се чуваат во **public class BirdsDoc** , која содржи листа на објекти од **public class Bird** , која претставува основниот објект во целата игра.

public class BirdsDoc

{

public List\&lt;Bird\&gt; Birds { get; set; }

public int points { get; set; }

private SoundPlayer[] sounds;

}

Во оваа класа, е сместена функцијата која претставува основна за проверка дали играчот погодил птица, а со тоа и освоил поени. Оваа функција го користи методот **isHit(float x,float y)** од класата **Bird** , која е објаснета подоле во текстот. Со креирање на секоја птица, тој се додава во главната листа каде се чуваат сите птици видливи за играчот. За секоја од птиците (објекти од класата **Bird** ), се чува и **Boolean Flag** , со која одбележуваме дали птицата е погодена. Потоа, повторно ја изминуваме листата, и овојпат проверуваме дали сме погодиле птица или бомба (и бомба е објект од класата **Bird** ). Aко сме погодиле бомба, се одземаат 5 поени од вкупниот број на поени досега, ако е птица, се додаваат 10 поени. Со секој клик на маусот се генерира и звук, во зависно дали сме погодиле птица или бомба.

public void CheckForExplosions(float x, float y)

{

for (int i = 0; i \&lt; Birds.Count; i++)

{

for (int j = i + 1; j \&lt; Birds.Count; j++)

{

if (Birds[i].IsHit(x, y))

{

Birds[i].Flag = true;

}

}

}

for (int i = Birds.Count - 1; i \&gt;= 0; i--)

{

if (Birds[i].Flag)

{

if (Birds[i].bomba == true)

{

sounds[0].Play();

points -= 5;

}

else

{

Random random = new Random();

int ran = random.Next(1, 5);

sounds[ran].Play();

points += 10;

}

Birds.RemoveAt(i);

}

else

{

sounds[7].Play();

}

}

}

public class Bird

{

public Point Center { get; set; }

public Color Color { get; set; }

public bool bomba { get; set; }

public Image slika { get; set; }

Image[] niza;

public double Velocity { get; set; }

public double Angle { get; set; }

private float velocityX;

private float velocityY;

public bool Flag { get; set; }

public bool IsColided { get; set; }

}

Во функцијата **CheckForExplosions(float x,float y)**, гo користиме методот **isHit(float x,float y)** од класата **Bird** , со која всушност проверуваме дали сме ја погодиле птицата. Во оваа проверка ја користиме и позицијата на која кликнал играчот, која ја пренесуваме како аргументи на функцијата.

public bool IsHit(float x, float y)

{

Point nova = new Point((int)x, (int)y);

if (nova.Y \&lt;= (Center.Y + 90) &amp;&amp; nova.Y \&gt;= (Center.Y))

{

if (nova.X \&lt;= (Center.X + 65) &amp;&amp; nova.X \&gt;= (Center.X))

return true;

else return false;

}

else

return false;

}

Исто така, имаме **public class Player** , која го претставува секој играч со името и вкупниот број на освоени поени. Тука ја имаме преоптоварено функцијата **toString()** со која се запишува играчот во формат &quot;име – вкупно поени&quot;.

public class Player

{

public string name { get; set; }

public int points { get; set; }

public Player(string name, int points)

{

this.name = name;

this.points = points;

}

public override string ToString()

{

return this.name +&quot;        -        &quot; +this.points;

}

}

Во класата на основтана форма **(Form1.cs)** се сместени сите функции и настани кои ја прават играта онаква каква што е. Времето го следиме со поставување на тајмер на самата форма и со секое отчукување на 1 секунда, се генерираат нови птици во зависнот од тежината што играчот ја одбрал. Интересно во овој дел е дека бројот на птици се зголемува, како што се намалува времето за игра. Па така, до 30тата секунда имаме една брзина на појавување на птиците. Во интервал од 30тата-90тата секунда, појавувањето е побрзо и на крај тоа го достигнува својот максимум. Доколку не е убиена некоја птица, од преостанатото време се одземаат 5 секунди. Генерирањето на нови птици ја правиме со помош на вградената класа **Random** , со чија помош ја одредуваме локацијата на која ќе се појави новата птица. Исто така истата класа ја користиме за да одредиме и каква птица (или бомба) треба да се појави, чувајќи ги сликите од сите птици и бомбата во низа од слики **(Image [] niza)**.

void timer\_Tick(object sender, EventArgs e)

{

doc.MoveBirds();

if (verticalProgressBar1.Value \&lt;= 95)

{

if (doc.CheckMissed())

{

verticalProgressBar1.Value += 5;

}

}

else

{

if (doc.CheckMissed())

{

verticalProgressBar1.Value = 100;

}

}

if (nivo.Equals(&quot;Easy&quot;))

{

if (count1 \&lt;= 30)

{

if (count % 25 == 0)

{

Random random = new Random();

Point newLocation = new Point(random.Next(100, this.width - 230), height);

int x = random.Next(0, 4);

Bird nov = new Bird(newLocation, Color.Red, niza[x]);

if (x == 1)

nov.bomba = true;

doc.AddBird(nov);

}

}

else if (count1 \&gt; 30 &amp;&amp; count \&lt; 90)

{

if (count % 20 == 0)

{

Random random = new Random();

Point newLocation = new Point(random.Next(70, this.Width - 150), height);

int x = random.Next(0, 4);

Bird nov = new Bird(newLocation, Color.Red, niza[x]);

if (x == 1)

nov.bomba = true;

doc.AddBird(nov);

}

}

else

{

if (count % 15 == 0)

{

Random random = new Random();

Point newLocation = new Point(random.Next(70, this.Width - 150), height);

int x = random.Next(0, 4);

Bird nov = new Bird(newLocation, Color.Red, niza[x]);

if (x == 1)

nov.bomba = true;

doc.AddBird(nov);

}

}

}

else if (nivo.Equals(&quot;Medium&quot;))

{

if (count1 \&lt;= 30)

{

if (count % 20 == 0)

{

Random random = new Random();

Point newLocation = new Point(random.Next(70, this.width - 150), height);

int x = random.Next(0, 4);

Bird nov = new Bird(newLocation, Color.Red, niza[x]);

if (x == 1)

nov.bomba = true;

doc.AddBird(nov);

}

}

else if (count1 \&gt; 30 &amp;&amp; count \&lt; 90)

{

if (count % 15 == 0)

{

Random random = new Random();

Point newLocation = new Point(random.Next(70, this.Width - 150), height);

int x = random.Next(0, 4);

Bird nov = new Bird(newLocation, Color.Red, niza[x]);

if (x == 1)

nov.bomba = true;

doc.AddBird(nov);

}

}

else

{

if (count % 10 == 0)

{

Random random = new Random();

Point newLocation = new Point(random.Next(70, this.Width - 150), height);

int x = random.Next(0, 4);

Bird nov = new Bird(newLocation, Color.Red, niza[x]);

if (x == 1)

nov.bomba = true;

doc.AddBird(nov);

}

}

}

else

{

if (count1 \&lt;= 30)

{

if (count % 15 == 0)

{

Random random = new Random();

Point newLocation = new Point(random.Next(70, this.width - 150), height);

int x = random.Next(0, 4);

Bird nov = new Bird(newLocation, Color.Red, niza[x]);

if (x == 1)

nov.bomba = true;

doc.AddBird(nov);

}

}

else if (count1 \&gt; 30 &amp;&amp; count \&lt; 90)

{

if (count % 10 == 0)

{

Random random = new Random();

Point newLocation = new Point(random.Next(70, this.Width - 150), height);

int x = random.Next(0, 4);

Bird nov = new Bird(newLocation, Color.Red, niza[x]);

if (x == 1)

nov.bomba = true;

doc.AddBird(nov);

}

}

else

{

if (count % 5 == 0)

{

Random random = new Random();

Point newLocation = new Point(random.Next(70, this.Width - 150), height);

int x = random.Next(0, 4);

Bird nov = new Bird(newLocation, Color.Red, niza[x]);

if (x == 1)

nov.bomba = true;

doc.AddBird(nov);

}

}

}

count++;

Invalidate(true);

}

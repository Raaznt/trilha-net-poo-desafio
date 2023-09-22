using DesafioPOO.Models;


Smartphone s1 = new Nokia("(17)984902201", "AB-0X-91", "918273744992", 32);
s1.Ligar();
s1.ReceberLigacao();
s1.InstalarAplicativo("Tetris");

Smartphone s2 = new Iphone("(11)987059432", "VK-45-09", "900231733249", 64);
s2.Ligar();
s2.ReceberLigacao();
s2.InstalarAplicativo("Angry Birds");
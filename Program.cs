using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone5 = new Iphone("9182638", "iphone 5", "234124", 16);
Nokia nokia1 = new Nokia("1278123", "nokia 1 ", "12879634", 8);

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Whatsapp");
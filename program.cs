using System;
using System.Collections.Generic;				
public class Program
{
	public static void Main()
	{
		//		=========[Item Price]=========
		double jasmine = 249.50;
		double cinderella = 250.75;
		double ariel = 259.55;
		double mulan = 234.25;
		double aurora = 270.75;
		double belle = 289.50;
		double elsa = 289.75;
		double anna = 262.25;
		double snow = 259.50;
		double rapunzel = 264.75;
		//		=========[Cash and Input]=========
		double cash;
		int quantity;
		int endPrompter;
		int itemID;
		int response;
		int removeResponse;
		int prompt;
		//		=========[List | Arrays]=========
		List<string> cart = new List<string>();
		List<string> cartName = new List<string>();
		List<int> cartQuantity = new List<int>();
		List<double> quantityPrice = new List<double>();
		double total = 0;
        start:
		Console.WriteLine("[====================[Menu by Sureiya Shop]=====================]");
		Console.WriteLine("[Item ID] \tItem Name\t\t Price\n");
		Console.WriteLine("|  001  |\tJasmine Necklace\t 249.50");
		Console.WriteLine("|  002  |\tCinderella Necklace\t 250.75");
		Console.WriteLine("|  003  |\tAriel Necklace\t\t 259.55");
		Console.WriteLine("|  004  |\tMulan Necklace\t\t 234.25");	
		Console.WriteLine("|  005  |\tAurora Necklace\t\t 270.75");
		Console.WriteLine("|  006  |\tBelle Necklace\t\t 289.50");
		Console.WriteLine("|  007  |\tElsa Necklace\t\t 289.75");
		Console.WriteLine("|  008  |\tAnna Necklace\t\t 262.25");
		Console.WriteLine("|  009  |\tSnow White Necklace \t 259.50");	
		Console.WriteLine("|  010  |\tRapunzel Necklace \t 264.75");
		Console.WriteLine("[==============================================================]");
	while(true){

		Console.WriteLine("[Type the item code of your item]:");
		
		try{
		itemID = int.Parse(Console.ReadLine());
		}catch(Exception e){
		Console.WriteLine("[Invalid]: Please enter a valid ID.\n");
	    goto start;		
		}
		switch(itemID){
			case 001:
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Enter quantity]: ");
			quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Jasmine Necklace]: " + quantity + "x");
			cart.Add("001");
			cartName.Add("Jasmine Necklace");
			cartQuantity.Add(quantity);
			double jasmineTotal = jasmine * quantity;
			quantityPrice.Add(jasmineTotal);
			goto prompt;
			break;

			case 002:
						Console.WriteLine("[==============================================================]");
			Console.WriteLine("Enter quantity: ");
			quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Cinderella Necklace]: " + quantity + "x");
			cart.Add("002");
			cartName.Add("Cinderella Necklace");
			cartQuantity.Add(quantity);
			double cinderellaTotal = cinderella * quantity;
			quantityPrice.Add(cinderellaTotal);
			goto prompt;
			break;
			
			case 003:
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("Enter quantity: ");
			quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Ariel Necklace]: " + quantity + "x");
			cart.Add("003");
			cartName.Add("Ariel Necklace\t");
			cartQuantity.Add(quantity);
			double arielTotal = ariel * quantity;
			quantityPrice.Add(arielTotal);
			goto prompt;
			break;

			case 004:

			Console.WriteLine("[==============================================================]");
			Console.WriteLine("Enter quantity: ");
			quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Mulan Necklace]: " + quantity + "x");
			cart.Add("004");
			cartName.Add("Mulan Necklace\t");
			cartQuantity.Add(quantity);
			double mulanTotal = mulan * quantity;
			quantityPrice.Add(mulanTotal);
			goto prompt;
			break;

			case 005:

			Console.WriteLine("[==============================================================]");
			Console.WriteLine("Enter quantity: ");
			quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Aurora Necklace]: " + quantity + "x");
			cart.Add("005");
			cartName.Add("Aurora Necklace\t");
			cartQuantity.Add(quantity);
			double auroraTotal = aurora * quantity;
			quantityPrice.Add(auroraTotal);
			goto prompt;
			break;

			case 006:

			Console.WriteLine("[==============================================================]");
			Console.WriteLine("Enter quantity: ");
			quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Belle Necklace]: " + quantity + "x");
			cart.Add("006");
			cartName.Add("Belle Necklace\t");
			cartQuantity.Add(quantity);
			double belleTotal = belle * quantity;
			quantityPrice.Add(belleTotal);
			goto prompt;
			break;

			case 007:

			Console.WriteLine("[==============================================================]");
			Console.WriteLine("Enter quantity: ");
			quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Elsa Necklace]: " + quantity + "x");
			cart.Add("007");
			cartName.Add("Elsa Necklace\t");
			cartQuantity.Add(quantity);
			double elsaTotal = elsa * quantity;
			quantityPrice.Add(elsaTotal);
			goto prompt;
			break;

			case 008:

			Console.WriteLine("[==============================================================]");
			Console.WriteLine("Enter quantity: ");
			quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Anna Necklace]: " + quantity + "x");
			cart.Add("008");
			cartName.Add("Anna Necklace\t");
			cartQuantity.Add(quantity);
			double annaTotal = anna * quantity;
			quantityPrice.Add(annaTotal);
			goto prompt;
			break;

			case 009:

			Console.WriteLine("[==============================================================]");
			Console.WriteLine("Enter quantity: ");
			quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Snow White Necklace]: " + quantity + "x");
			cart.Add("009");
			cartName.Add("Snow White Necklace");
			cartQuantity.Add(quantity);
			double snowWhiteTotal = snow * quantity;
			quantityPrice.Add(snowWhiteTotal);
			goto prompt;
			break;

			case 010:

			Console.WriteLine("[==============================================================]");
			Console.WriteLine("Enter quantity: ");
			quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Rapunzel Necklace]: " + quantity + "x");
			cart.Add("010");
			cartName.Add("Rapunzel Necklace");
			cartQuantity.Add(quantity);
			double rapunzelTotal = rapunzel * quantity;
			quantityPrice.Add(rapunzelTotal);
			goto prompt;
			break;

			default:
			Console.WriteLine("[Invalid]: Please enter a valid ID.\n");
			break;
		}
	}
		prompt:
		while(true){
		question:
		Console.WriteLine("[============================= Cart ===========================]\n");
		Console.WriteLine("[No.]\t[ID]\t[Item Name]\t\t[Quantity]\t[Price]");
		for(int i=0; i<cart.Count; i++)
		{
			Console.WriteLine((i+1) + "   |\t" + cart[i].ToString() + "\t" + cartName[i].ToString() + "\t" + cartQuantity[i].ToString() + "X\t\t" + quantityPrice[i].ToString());
		}
		Console.WriteLine("[============================ Total ===========================]");
		double sum=0;
		for(int i=0; i<quantityPrice.Count; i++){
		sum = sum + quantityPrice[i];
		}
		Console.WriteLine("TOTAL:  " + sum + "php");
		Console.WriteLine("[==============================================================]");
		Console.WriteLine("Type [00] | Add more items.\nType [05] | Remove an item.\nType [09] | Check out."); 
		try{
		response = int.Parse(Console.ReadLine());
		}catch(Exception e){
		Console.WriteLine("[Invalid]: Please enter a valid response.\n");
	    goto question;		
		}
		switch(response){
			case 00:
			goto start;
			break;


			case 09:
		checkout:
		Console.WriteLine("[============================= Cart ===========================]\n");
		Console.WriteLine("[No.]\t[ID]\t[Item Name]\t\t[Quantity]\t[Price]");
		for(int i=0; i<cart.Count; i++)
		{
			Console.WriteLine((i+1) + "   |\t" + cart[i].ToString() + "\t" + cartName[i].ToString() + "\t" + cartQuantity[i].ToString() + "X\t\t" + quantityPrice[i].ToString());
		}
		Console.WriteLine("[============================ Total ===========================]");
		double totalPrice=0;
		for(int i=0; i<quantityPrice.Count; i++){
		totalPrice = totalPrice + quantityPrice[i];
		}
		Console.WriteLine("TOTAL:  " + totalPrice + "php");
		Console.WriteLine("[========================== Check Out =========================]");
		Console.WriteLine("[Enter Cash]: "); 
		try{ 
		cash = Convert.ToDouble(Console.ReadLine());
		}catch(Exception e){
		Console.WriteLine("[Invalid]: Please enter a valid amount of cash.\n");
	    goto checkout;
		}
		if (totalPrice < cash) {
		Console.WriteLine("[=========================== Receipt ==========================]\n");
		Console.WriteLine("[No.]\t[ID]\t[Item Name]\t\t[Quantity]\t[Price]");
		for(int i=0; i<cart.Count; i++)
		{
			Console.WriteLine((i+1) + "   |\t" + cart[i].ToString() + "\t" + cartName[i].ToString() + "\t" + cartQuantity[i].ToString() + "X\t\t" + quantityPrice[i].ToString());
		}
		Console.WriteLine("[============================ Total ===========================]");
		Console.WriteLine("TOTAL:  " + totalPrice + "php");
		Console.WriteLine("CASH:  " + cash + "php");
		Console.WriteLine("CHANGE: " + Math.Round(cash - totalPrice, 2)  + "php");
				promptEnd:
		Console.WriteLine("[==============================================================]");
		Console.WriteLine("Type [00] | Restart.\nType [09] Exit.");
		try{
		endPrompter = int.Parse(Console.ReadLine());
		}catch(Exception e){
		Console.WriteLine("[Invalid]: Please enter a valid response.\n");
		goto promptEnd;
		}
		switch(endPrompter){
			case 00:
			cart.Clear();
			cartName.Clear();
			cartQuantity.Clear();
			quantityPrice.Clear();
			goto start;
			break;
			case 09:
			Console.WriteLine("[Program]: Closing...\n");
			goto end;
			break;
			default:
			Console.WriteLine("[Invalid]: Please enter a valid response.\n");
			goto promptEnd;
			break;
		}
        }else {
		Console.WriteLine("[==============================================================]");
        Console.WriteLine("[Error]: Insufficient cash");
		promptCheckout:
		Console.WriteLine("[==============================================================]");
		Console.WriteLine("Type [00] | Re-enter money.\nType [05] | Clear cart/restart."); 
		try{
			prompt = int.Parse(Console.ReadLine());
		}catch(Exception e){
		Console.WriteLine("[Invalid]: Please enter a valid response.\n");
		goto promptCheckout;
		}
		switch(prompt){
			case 00:
			goto checkout;
			break;
			case 05:
			cart.Clear();
			cartName.Clear();
			cartQuantity.Clear();
			quantityPrice.Clear();
			goto start;
			break;
			default:
			Console.WriteLine("[Invalid]: Please enter a valid response.\n");
			goto promptCheckout;
			break;
		}
        }
			break;
			


			case 05:
			Console.WriteLine("[============================= Cart ===========================]\n");
			Console.WriteLine("[No.]\t[ID]\t[Item Name]\t\t[Quantity]\t[Price]");
			for(int i=0; i<cart.Count; i++)
			{
			Console.WriteLine((i+1) + "   |\t" + cart[i].ToString() + "\t" + cartName[i].ToString() + "\t" + cartQuantity[i].ToString() + "X\t\t" + quantityPrice[i].ToString());
			}
			Console.WriteLine("[==============================================================]");
			Console.WriteLine("[Type the cart no. to remove]:");
			try{
			removeResponse = int.Parse(Console.ReadLine());
			}catch(Exception e){
			Console.WriteLine("[Invalid]: Please enter a valid cart no.\n");
			goto question;
			}
			if(removeResponse > cart.Count || removeResponse <= 0){
			Console.WriteLine("[Invalid]: Please enter a valid cart no.\n");
			}else{
			cart.RemoveAt(removeResponse - 1);
			cartName.RemoveAt(removeResponse - 1);
			cartQuantity.RemoveAt(removeResponse - 1);
			quantityPrice.RemoveAt(removeResponse - 1);
			for(int i=0; i<cart.Count; i++)
			{
			Console.WriteLine((i+1) + "   |\t" + cart[i].ToString() + "\t" + cartName[i].ToString() + "\t" + cartQuantity[i].ToString() + "X\t\t" + quantityPrice[i].ToString());
			}
			}
			break;
			default:
			Console.WriteLine("[Invalid]: Please enter a valid response.\n");
			goto question;
			break;
		}
		}
		end:
		Console.WriteLine("[==============================================================]");
		Console.WriteLine("Thank You For Shopping 🙂");
}
	}
	SubProceso Cargar(nombre, telefono,abono,DNI)
		definir contador como entero;
		contador<-0;
		
	   
		Limpiar Pantalla;
		
		Para contador<-0 Hasta 3 Con Paso 1 Hacer
			Escribir "";
			Escribir "[ " ,contador +1, " ]";
			
			Escribir "Nombre: ";
			leer nombre[contador];
			
			Escribir "Telefono: +54 - ";
			Leer telefono[contador];
			
			Escribir "DNI: ";
			Leer DNI[contador];
			
			Escribir "¿Cuanto va a abonar?: ";
			Leer Abono[contador];
			Escribir "";
			
			Escribir "Lista guardada en BBDD ", + contador +1;
			Escribir "";
			escribir"Nombre: ",nombre[contador];
			escribir"Tel: ", telefono[contador];
			escribir"DNI: ", DNI[contador];
			escribir"Abono: ", Abono[contador];
		
		
		FinPara
	
FinSubProceso
//Inscripciones
//carga de datos del inscripto
//Buscar al inscripto
//solo admite 5 incriptos, porque tiene limites. 

Proceso EvalucionIntento2
	
	definir nombre Como Cadena;
	definir telefono como entero;
	Dimension nombre[4], telefono[4];
	
	Definir contador como entero;
	contador<-0;
	
	Definir Abono como real;
	Definir DNI como entero;
	
	Dimension DNI[4],Abono[4];
		
	Definir opcionLista como entero;
	opcionLista<-0;
	
	
	definir contadoroP como entero;
	contadoroP<-0;

	
	Repetir
		
		Escribir "------------ INCRIPCIONES ------------";
		Escribir "";
		Escribir "1. Cargar";
		Escribir "2. Mostrar Lista completa";
		Escribir "9. Salir";
		Leer opcionLista;
		
		Si opcionLista > 0 entonces
			
			Segun opcionLista Hacer
				1: //cargar
					
					Cargar(nombre, telefono,abono,DNI);
					
				2:				
					//mostrar lista	
					Limpiar Pantalla;
					para contador <-0 hasta 3 con paso 1 hacer
						Escribir "";
						Escribir "<< BBDD " , contador +1, " >>";
						escribir"Nombre: ",nombre[contador];
						escribir"Tel: ", telefono[contador];
						escribir"DNI: ", DNI[contador];
						escribir"Abono: $", Abono[contador];
					FinPara
					esperar 1 segundo;
				9:
					Escribir "Ok, ha salido del programa, saludos.";
					
			FinSegun
			
			
		FinSi
		
		
	Hasta Que opcionLista=9;	
	
FinProceso



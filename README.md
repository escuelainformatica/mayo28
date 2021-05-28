# mayo28

## Operadores binarios lógicos

| Operador | explicación   | ejemplo                  |
| -------- | ------------- | ------------------------ |
| <        | Menor         | 20<30                    |
| >        | Mayor         | 30>40                    |
| <=       | Menor o igual | 20<=30                   |
| >=       | Mayor o igual | 40>=30                   |
| ==       | igualdad      | 20==20   "hola"=="mundo" |
| !=       | no igualdad   | 20!=30  "hola"!="mundo"  |
| &&       | Sí lógico     | n1<n2 &&  n1<n3          |
| \|\|     | Ó lógico      | n1<n2 \|\| 1<n3          |
|          |               |                          |

## condiciones

```c#
if ( condicion) {
    // hacer algo si la condicion se cumple
} else {
    // hacer algo si la condicion no se cumple
}
```

## Switch y case

```c#
        switch(num3)
        {
            case 1:
                Console.WriteLine("uno");
                break;
            case 2:
                Console.WriteLine("dos");
                break;
            case 3:
                Console.WriteLine("tres");
                break;
            default:
                Console.WriteLine("otro numero");
                break; // salir del bloque de codigo
        }
```
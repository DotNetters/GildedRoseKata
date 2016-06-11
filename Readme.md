# Kata de refactoring Gilded Rose (#FridayDojo con @AgileAragon)

## Introducción 
En este repositorio se encuentra el código de nuestra participación en las katas de refactoring que organizaron  la gente de [Agile Aragón](http://agile-aragon.org/) y [SenpaiDevs](https://twitter.com/SenpaiDevs) el [27/04/2016](http://www.meetup.com/es-ES/agilearagon/events/231413322/) y [10/06/2016](http://www.meetup.com/es-ES/agilearagon/events/231598524/)

## Entorno
El entorno de desarrollo necesario para utilizar el código de esta kata se compone de:
- [Visual Studio Community 2015](https://www.visualstudio.com/products/visual-studio-community-vs): versión gratuita de nuestro IDE favorito para trabajar con .NET
- [NUnit](http://www.nunit.org/): framework utilizado para implementar las pruebas. 
- [OpenCover](https://github.com/OpenCover/opencover) + [OpenCover UI](https://github.com/OpenCoverUI/OpenCover.UI): herramienta para analizar la cobertura de pruebas y extensión para Visual Studio que permite visualizar los resultados         

## Soluciones
Este repositorio incluye varias ramas con distintas soluciones a la cata
- **Rama master:** resultado del primer #FridayDojo realizado entre [@jesusArnas](https://twitter.com/jesusArnas) y [@rsciriano](https://twitter.com/jesusArnas) donde se implementaron las pruebas   
- **Rama FD2:** resultado del segundo #FridayDojo realizado entre [@alexmorosmarco](https://twitter.com/alexmorosmarco) y [@rsciriano](https://twitter.com/rsciriano)

> Se pueden ver más detalles de cada solución en la rama correspondiente            

## La kata Gilded Rose ##
*([texto traducido al español por francho](https://github.com/francho/kata-betabeers/blob/master/README.md#la-kata-gilded-rose))*

Tenemos un sistema de inventario desarrollado por un tipo un tanto peculiar y con poco sentido común llamado Leeory, ahora esta persiguiendo nuevas aventuras!, tanta paz lleves como descanso dejas amigo Leeroy!. Tu tarea consiste en añadir una nueva funcionalidad al sistema para que podamos empezar a vender una nueva categoría de items. Para empezar una pequeña introducción a nuestro sistema:

- Todos los items tienen una fecha de venta, SellIn , que especifica el número de días que tenemos para vender el item.
- Todos los items tienen una calidad , Quality , que especifica el valor que tiene un item.
- Al final del día el sistema reduce los valores para los dos valores de cada item.

Simple ¿no?, ahora empieza lo interesante:

- Los items degradan la calidad en una unidad por cada actualización.
- Cuando la fecha de venta a pasado, la calidad degrada al doble de velocidad.
- La calidad de un item no es nunca negativa.
- El item "aged brie" incrementa su calidad en lugar de decrementarla según pasan los días.
- La calidad de un item nunca es mayor de 50.
- El item "Sulfuras", nuestro articulo más legendario!, nunca debe venderse ni disminuye su calidad.
- los "backstage passes" incrementan su calidad conforme se aproxima la fecha de venta. La calidad se incrementa por dos cuando quedan 10 días o menos para el concierto, por 3 cuando quedan 5 días o menos. Sin embargo la calidad disminuye a 0 después del concierto.

Hemos firmado un nuevo acuerdo para vender items "conjured", sin embargo necesitamos un cambio en el sistema:

- Los items "conjured" disminuyen de calidad el doble de rápido que el resto.

Por supuesto puedes hacer cualquier cambio al método updateQuality si lo consideras necesario mientras que todo siga funcionando claro esta!. Sin embargo **hay dos cosas que no puedes hacer**:

- **Cambiar el interfaz** y la forma de uso de GildedRose (la función update_quality), es fea, lo sabemos, pero tenemos muchos sistemas que la utilizan y no vamos a cambiarlos todos ahora!
- **¡No puedes tocar la clase item!**. Pertenece a una especie de goblin asesino que no cree en cosas como la propiedad colectiva del código.
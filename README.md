# &#x20;           Rouletteapp

&#x20;                           .NET cli app for roulette gambling

\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_



Aplicación de terminal que simula el funcionamiento de una ruleta de apuestas europea (diferenciada por tener sólo un cero).







=Métodos de .NET Class Library =



Descarté el uso de System.Random ya que es un generador de números pseudoaleatorios (más predecibles), en su lugar utilicé:



RandomNumberGenerator que viene dentro de System.Security.Criptography el cual genera valores aleatorios criptográficamente

seguros (más difíciles de predecir).



RandomNumberGenerator.GetInt(0,37); -< Genera un entero desde el 0 (incluyéndolo) al 36 (37-1)








=Disclaimer=


Con la intención de hacer más rápido el proceso de aprendizaje se usaron LLM's como referencia para comprender de mejor

manera la documentación oficial de .NET de Microsoft para el lenguaje de C#, así como poder ver ejemplos de uso del código.

Modelos usados:

High-Flyer - DeepSeek-V3

Antropic - Claude Haiku 4.5 (desde Duck.ai)



\*TODO EL CÓDIGO Y LA LÓGICA FUE ESCRITA POR MÍ\*














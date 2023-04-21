<h1>Jentse Vander Hulst Jumper Oefening</h1>

<P>
Om de agent te laten trainen hebben we een omgeving nodig waarin deze zich kan trainen.
Hiervoor maken we een eenvoudige opstelling.
WE zetten in het midden van de wereld een platform dat we Floor noemen, Hierop plaatsen we onze Agent die een normal kubus is.
Vervolgens rondom het platform kiezen we twee punten vanwaar we onze objects willen spawnen dat onze Agent zal moeten ontwijken.
Dit zijn child objects van de omgeving.
<br>
We maken een prefab aan dat als object zal dienen dat de Agent zal ontwijken, in mijn voorbeeld is dit een gewone rode bal.
We geven de nodige attributen mee aan onze Agent zoals een Rigidbody, Collider, Agent script, decision script en Ray perceptors.
<br>
De floor geven we ook een Tag mee genaamd "Floor", deze gebruiken we later in de code om te checken wanneer de Agent op de grond staat.
<br>
Onze bal is een gewone Sphere met een rigid body en een collider, we geven de bal ook een Tag mee genaamd "Ball".
We maken van dit object een prefab zodat we dit later kunnen spawnen met onze ballspawners. We geven dit ook het Ball script mee.
<br>
Ballspawners krijgen gewoon een fixed positie en het Ballspawner script mee. Hier moet verder niets ingesteld worden.
</p>

Vervolgens starten we het trainen met mlagents-learn en laten we onze Agent leren. 

<h2> Training Graph </h2>
![Training graph of the agent](/Assets/Images/training.jpg "Agent's learning graph")
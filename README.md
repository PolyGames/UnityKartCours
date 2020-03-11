# UnityKart - Cours Unity pour débutants par Poly Games

## Atelier Unity H20 #1
Au programme:
- Créer un projet Unity3D
- Découvrir l'interface de l'éditeur
- Comprendre la boucle d'exécution
- Utiliser le système de gestion des entrées

#### Créer un projet Unity3D
Tout d’abord il faut démarrer Unity, ou le Unity Hub. La version Hub est fortement encouragée, puisque celle-ci permet d’organiser plusieurs versions de Unity pour supporter différents projets. Le hub offre également des choses intéressantes, comme une section Learn qui contient des tutoriels (et même une version d’un clone de Mario Kart!). Je suggère que les étudiants intéressés à en apprendre davantage passent à travers quelques tutoriels de Unity. Ils sont parfois trop complexes niveau code pour des débutants, mais chacun offre des connaissances intéressantes. Ici il est possible de se connecter avec son compte Unity, mais ce n’est pas obligatoire. Il suffit de sélectionner « New » et de choisir les configurations souhaitées. Dans notre cas nous allons vouloir prendre les packages par défaut pour 3D puisque l’atelier sera en trois dimensions. On peut également choisir le répertoire où est créé le projet. Une fois que tout est fait, il ne reste plus qu’à attendre que Unity configure le reste et nous redirige vers l’éditeur contenant un projet de base.

#### Découvrir l'interface de l'éditeur
L’interface de Unity peut sembler un peu chargé pour ceux qui ne l’ont jamais vu. Nous allons passer à travers chaque fenêtre de base pour vous permettre de vous familiariser avec l’interface. D’ailleurs Unity est composé d’un système de sous-fenêtres. Libre à vous de les déplacer comme bon vous semble. Personnellement j’aime bien avoir la fenêtre de « Scene » et de « Game » visible en même temps puisque je trouve qu’il est pratique d’avoir une vue d’ensemble ainsi que la vue de joueur lors de l’exécution du jeu.
-	Scene : Contient un affichage graphique des objets présent dans la scène. Tout d’abord, Unity charge une scène de départ. On peut considérer les scènes comme étant des niveaux différents, ou encore des décors. À chaque scène est rattaché des objets, communément appelés « GameObjects » dans le cadre de Unity. On peut les déplacer dans la scène pour que lors de l’exécution les objets aillent une position, une rotation ou une échelle déterminée. Il est très pratique d’apprendre à être à l’aise pour déplacer la caméra de la fenêtre de scène. Si l’on maintient le clic-droit et que l’on bouge la souris, la caméra va pointer dans des nouvelles directions selon le déplacement. Il est également possible de bouger la position de la caméra en utilisant « W », « A », « S » et « D » lorsque le clic-droit est enfoncé. Aussi, une touche importante pour bouger la caméra est le « Alt » de gauche. En enfonçant cette touche et le clic-gauche, la caméra pourra maintenant se déplacer en rotation autour d’un point. Une chose bien pratique que l’on peut faire avec cette rotation est de cliquer sur un objet, peser sur « F » pour en prendre le focus, et ensuite la rotation se fera selon le centre de cet objet, permettant à l’utilisateur de tourner au tour d’un objet. Il existe également une icone en haut à droite de l’écran de la scène qui nous indique les axes. Si l’on clique sur cet icone, il est possible de bouger automatiquement la caméra pour voir certains plans, et il est possible de changer la projection pour obtenir une vue en perspective ou une vue isométrique. 

-	Hierarchy : Cette fenêtre contient tous les GameObjects présents dans la scène. On peut en créer ici avec un clic droit et on peut sélectionner « Cube » dans « 3D Objects ». On va le voir apparaitre à l’écran dans la scène, et on pourra le manipuler bientôt.

-	Inspector : Il s’agit de la fenêtre qui nous offre la possibilité de modifier les attributs et les composantes des GameObjects. Par exemple, si l’on a un cube dans notre scène et qu’on le sélectionne, l’inspecteur nous permettra de modifier sa position, rotation, échelle ou nom directement en modifiant sa valeur. Il est également possible de le faire à partir de la scène, soit en sélectionnant un des outils en haut à gauche qui nous permet de modifier la position, la rotation et l’échelle directement dans la scène. C’est pratique de le faire directement dans la scène pour avoir une idée visuelle et graduelle du résultat, mais pour des valeurs précises il est mieux de les entrer dans l’inspecteur. Dans l’inspecteur, il est également possible d’ajouter des composantes à nos GameObjects. Pour notre cube, on peut voir qu’il possède déjà certaines composantes comme un Box Collider, un MeshRenderer et un MeshFilter. On pourrait lui ajouter un RigidBody pour qu’il soit affecté par le système interne de physique de Unity, ou encore on pourrait lui ajouter un script quelconque qui lui donne une utilité déterminée par vous. Pour l’instant, nous allons laisser le cube ainsi.

-	Game : Vous avez surement vu qu’il y avait un onglet « Game » à coté de scène? Si l’on clique dessus, nous pourront voir ce que le joueur verra lorsqu’il entre pour la première fois dans la scène. Si l’on clique sur le bouton Play en haut au milieu de l’écran, la fenêtre de Game sera celle qui affichera le résultat du jeu d’une manière presque identique au résultat final.  

-	Console : Si vous avez déjà de l’expérience, que ce soit en programmation ou en informatique, vous savez probablement déjà ce qu’est une console. Unity offre un affichage en console utile pour afficher les erreurs que vous avez dans votre projet, que ce soit à cause de votre code ou d’une configuration manquante. Vous pouvez également afficher vos propres messages dans la console à partir de votre code.

-	Project : Cette fenêtre nous montre l’état du répertoire du projet. Nous avons accès à toutes les ressources créées ou utilisées par le projet. Par exemple, si l’on crée un script, il se retrouvera par ici par défaut. Je recommande fortement de créer un dossier nommé « Scripts » avec un clic droit afin de garder le projet structuré. 
Un autre endroit intéressant dans l’affichage de Unity est un peu plus caché. Il faut aller dans « Edit », et « Project Settings » pour avoir accès à un grand nombre de choses configurables sur le projet, par exemple le système d’entrées (Input), la gestion de la physique ou encore les configurations graphiques.

#### Comprendre la boucle d'exécution

La boucle d’exécution est l’un des concepts de base les plus importants à saisir à propos de Unity, et de la très grande majorité des jeux. Vous avez surement déjà entendu parler de « FPS »? Au long, c’est « Frames Per Seconds ». Il s’agit en fait du nombre de rafraichissement de l’écran par secondes, mais aussi du nombre de fois par secondes que l’on répète l’exécution de la logique du jeu. Au plus simple, Unity exécute une fonction d’initialisation une fois lors du démarrage, et ensuite il exécute en boucle autant de fois que possible la méthode de mise à jour. On met ainsi à jour tous les GameObjects, ce qui nous permet par exemple de modifier sa position à chaque frame pour le faire tomber, ou encore de récupérer les entrées au clavier et de les utiliser pour modifier l’état d’un GameObject. 

Pour vous montrer, on peut ajouter un script à notre cube, que l’on va nommer « Player ». On peut le faire de deux manières, soit : Aller dans la fenêtre Project, aller dans le dossier Scripts et faire un clic droit pour créer un nouveau C# Script, que l’on peut ajouter par la suite à notre objet, que ce soit en glissant le script sur l’objet dans la fenêtre de Scene, ou de glisser le script dans l’inspecteur après avoir sélectionné le cube. Il est également possible d’aller directement dans l’inspecteur, de cliquer sur Add Component, et d’ajouter un nouveau script, ou encore de sélectionner un script créé préalablement dans la fenêtre Project. 

Une fois le script ouvert dans Visual Studio, ou peu importe votre éditeur, vous pourrez voir le code par défaut, qui contient un Initialize() et un Update(); Pour vous montrer la boucle d’exécution, et comment utiliser la console, vous pouvez écrire « Debug.Log("Ceci est un message de la function Initialize") » dans la fonction Initialize, et un message similaire dans la fonction Update(). Ensuite, on va retourner dans Unity et faire Play. Comme vous pouvez le voir, la console affiche nos messages, en tout premier il y a celui de Initialize et ensuite celui de Update se répète autant de fois que la boucle est exécutée. C’est à travers cette boucle que l’aspect de gameplay et d’interactivité du jeu va passer.

#### Utiliser le système de gestion des entrées:

Un jeu n’est rien sans interactions de la part du joueur. Heureusement, Unity offre une manière assez simple pour configurer des entrées. Il s’agit d’un système qui fonctionne avec des axes. On peut configurer une touche positive et une touche négative. Lorsque la touche positive est enfoncée, la valeur de l’axe se rapproche rapidement de 1. Si la touche négative est pesée, la valeur de l’axe se dirigera vers -1. La vitesse de ce déplacement de la valeur est totalement configurable. Vous pouvez aller dans les Project Settings, sous l’onglet Input, pour constater que certains axes sont déjà présents. Nous utiliserons pour l’instant deux axes, un premier nommé Horizontal, et un second nommé Vertical. Les majuscules et les minuscules sont importantes ici. On peut choisir quelles touches seront utilisées par nos axes, mais les valeurs par défaut vont suffire. 

On peut retourner dans notre script de Player. On va ajouter une fonction GetInputs() dans le Update qui va aller chercher les valeurs des axes dans le système d’inputs de Unity. On va garder ces valeurs dans la classe de Player en tant qu’attribut privé. Ensuite, maintenant que nous avons accès en code à nos valeurs d’axes, on peut les utiliser pour manipuler l’objet lié à notre script. On peut ajouter une autre fonction dans le Update nommée « MoveTranslation », et dans celle-ci nous allons modifier la position de l’objet selon les inputs. Il existe une multitude de manières de bouger un objet dans Unity, mais dans le cadre du cours de débutant je vais vous montrer celle qui est la plus simple et la plus intuitive. Il suffit d’ajouter à « transform.position » tout déplacement souhaité, qui dans notre cas sera « transform.forward * speed * Time.deltaTime ». La variable speed n’existe pas encore, nous pouvons l’ajouter en haut dans la classe et la mettre en tant que « SerializeField », ce qui va nous permettre de modifier sa valeur directement dans l’éditeur de Unity, que ce soit en temps normal ou en pleine exécution. La multiplication par Time.deltaTime nous assure que peu importe la machine utilisée, nous allons toujours déplacer l’objet avec la même vitesse.

Lorsque l’on retourne dans l’éditeur de Unity, celui-ci va recomplier le code et appliquer les changements. Par exemple, la valeur « speed » sera maintenant accessible dans l’inspecteur. Vous pouvez maintenant peser sur Play et constater que le cube précédemment créé peut bouger grâce à son script que nous lui avons donné.

Nous allons vouloir faire certaines modifications à ce script, puisqu’il ne s’agit clairement pas encore d’un mouvement naturel pour une voiture. Il faudra également modifier le GameObject de la caméra pour lui ajouter un script qui peut suivre le joueur. Nous allons aussi ajouter des éléments de physique, de gestion événementielle de base ainsi que de la création d’objets lors du jeu, tout cela dans les prochaines séances.


Ce git sera mis à jour à mesure que les cours seront complétés, ce qui vous permettra de suivre avec les mêmes fichiers que moi, mais je recommande fortement de créer votre propre projet en même temps que je fais l’exemple lors du cours, comme ça vous pourrez faire toutes les étapes du début à la fin. N’hésitez pas à essayer de votre côté entre les séances pour avancer et découvrir Unity par vous-même! Je suggère que vous vous fassiez un second projet pour expérimenter et découvrir à votre vitesse. 

---

## Atelier Unity H20 #2
Au programme:
- Game design: brainstrom et choix des idées
- Rigidbody et physique dans Unity
- Mécanique d'un kart de base


#### Game design: brainstrom et choix des idées

Puisque le jeu de Mario Kart contient plusieurs fonctionnalités, il va falloir se limiter afin de faire un prototype minimaliste qui représente l'idée globale du jeu. Lors du brainstorm, nous avons trouvé les concepts suivants: Track (piste ou pistes de courses), Kart (le bolide que le joueur utilisera), Obstacles (Il serait intéressant d'avoir des obstacles que l'on pourrait placer sur les pistes pour varier le jeu), Items (par exemple une banane que l'on peut lancer sur la piste), et la caméra (nous allons devoir créer une caméra qui puisse suivre le joueur et son bolide). 

L'idée d'un brainstorm est de mettre en évidence quelles fonctionnalités sont les plus importantes, et lesquelles nous pourrions implémenter vers la fin du projet. J'ai également suggéré une base, c'est-à-dire de créer une classe de base qui s'occupera principalement de faire l'interface entre les différentes fonctionnalités suggérées. Nous pourrions également avoir un système d'événements dans cette classe centrale pour faciliter les interactions entre les différentes classes qui doivent interagir ensemble.

#### Rigidbody et physique dans Unity

Unity contient un système de gestion de la physique et des collisions en trois dimensions très efficace. Pour s'en servir, il suffit d'ajouter la composante "Rigidbody" à l'objet que nous souhaitons faire tomber avec la gravité, ou encore que nous voulons modifier par des forces. Une fois que cette composante est ajoutée à notre cube, il faut s'assurer que le cube soit également muni d'un box collider, qui sera lui même utilisé par le système afin de vérifier les collisions. 

#### Mécanique d'un kart de base

Notre cube peut présentement se déplacer de gauche à droite et de l'avant vers l'arrière. Afin d'obtenir un déplacement qui soit plus semblable à un kart, c'est-à-dire un déplacement qui ne peut être latéral que par une modification de l'angle, il faut faire quelques modifications au code. Nous avons ajouté, dans la méthode FixedUpdate, un appel à une méthode qui va gérer le mouvement sur l'axe frontal. Dans cette fonction, le but premier est de créer un déplacement lorsque l'on touche au sol (lorsque isGrounded est à true). Pour faire quelque chose de simple et d'intuitif, nous allons uniquement modifier la position du joueur pour donner l'impression d'un mouvement (je vous suggère d'apprendre et d'expérimenter par vous même pour remplacer cette manière de faire par une modification de l'attribut "velocity" de la composante Rigidbody). La classe du joueur contient une variable de type float qui représente la vitesse courante selon le vecteur frontal du bolide. Si le bolide touche au sol, il suffit d'incrémenter la vitesse selon une accélération. Nous allons également nous assurer de ralentir la vitesse afin de créer un certain freinage graduel, pour que le joueur ne puisse avancer que si l'accélérateur est enfoncé. Il faut s'assurer de prendre en note le vecteur frontal lorsque l'on touche au sol, afin de pouvoir l'utiliser lorsque nous sommes dans les airs et d'être capable de calculer la direction que doit prendre le kart.

Certains problèmes sont encore à modifier dans ce code, par exemple si l'on se promène trop près du bord de la piste, il est possible de créer un mouvement de rotation autour du kart causé par un problème avec le vecteur frontal. Dans la majorité des cas, l'implémentation utilisée en ce moment fonctionne, mais ce serait un problème qui vaut la peine d'être réglé.

Nous avons aussi ajouté une fonction qui est déclenchée lorsque le sol et le bolide entrent en contact afin de mettre la variable isGrounded à true, ainsi nous mettons les moteurs en marche que lorsque le joueur touche au sol.

---

## Atelier Unity H20 #3
Au programme:
- Mécanique d'un kart de base (suite)
- Collisions avec le sol
- Caméra subjective

#### Mécanique d'un kart de base (suite)

Suite au cours précédent, nous avions laissé de côté certains aspects du déplacement du kart. Lors du cours 3, nous avons ajouté un déplacement de rotation pour permettre au kart de tourner comme une voiture normale, au lieu de ne permettre que les déplacements sur l'axe frontal. La fonction de rotation, ajoutée dans le FixedUpdate, est simple. Si la vitesse du kart sur l'axe frontal est non nulle, et que le kart touche présentement au sol, alors il est possible de tourner, et ce, selon l'axe y, et avec une valeur que nous changeons par rapport à l'axe d'input horizontal. Nous multiplions également cette valeur par le signe de la vitesse dans l'axe frontal afin de déterminer le sens dans lequel le kart doit tourner, puisque ce sens doit être inversé lorsque nous sommes à reculon.

#### Collisions avec le sol

Dans la séance précédente, nous avons utilisé un booléen nommé isGrounded, qui était mis à true si le kart était en contact avec le sol, et false autrement. Il manquait quelques fonctions afin de compléter cette implémentation. Lorsque le joueur détecte une collision, et que le tag de l'autre objet est bien Ground, alors on peut déterminer la valeur que doit prendre isGrounded. Dans Unity, et dans le cadre de l'exemple, nous avons utilisé les trois fonctions, c'est-à-dire OnCollisionEnter, OnCollisionStay et OnCollisionExit. 

Comme les noms l'indiquent, la première est utilisée lorsque l'on entre en collision, la seconde lorsque nous sommes présentement en état de contact continu, et la troisième lorsque l'on met fin à la collision. Notez cependant qu'il s'agit d'interruptions, et qu'il est possible qu'un nombre indéterminé d'interruptions aient lieu en même temps. Par exemple, si l'on voulait réduire le nombre de points de vie d'un objet dès que l'on entre en collision, et que l'on soustrait directement la valeur dans la fonction OnCollisionEnter sans vérification, alors il se pourrait que la soustraction se fasse plusieurs fois de suite. Il faut donc faire attention avec l'utilisation de ces fonctions. Bien entendu, nous n'avons pas besoin de la fonction OnCollisionStay dans le cadre de cet exemple, mais nous l'avons ajouté à titre indicatif.

#### Caméra subjective

Le code de la caméra subjective n'est pas très compliqué. L'idée principale est d'interpoler entre deux positions: la position actuelle, et la prochaine position à laquelle nous voulons que la caméra soit. On peut calculer la prochaine position à l'aide d'un offset obtenu par définition dans l'inspecteur (d'où le SerializeField), et avec le Transform de l'objet que nous souhaitons observer, également obtenu dans l'éditeur. 

Dans le FixedUpdate, nous calculons la prochaine position, mais nous modifions également la position en y puisuqe l'on veut que celle-ci ne soit pas affectée par la rotation courante de l'objet observé. Par exemple, si le kart se trouve sur une rampe, le vecteur d'offset se retrouverait avec la même rotation que le kart, ce qui n'est pas voulu. L'application de la rotation sur l'offset est nécessaire puisqu'il faut pouvoir rester à l'arrière du kart. Ensuite, on utilise la fonction SmoothDamp de Vector3 avec nos positions, un vecteur passé par référence et un facteur d'interpolation. Le tout nous permettera d'obtenir un effet semblable à une caméra attachée avec un élastique au kart. Si le kart accélère, la caméra prendra un certain temps à obtenir la même vitesse, ce qui donne une impression d'accélération et qui permet de mieux voir lorsque le kart tourne. Ensuite nous modifions la rotation de la caméra afin de regarder dans la direction de l'objet observé.

#### Materials

Une autre modification pertinente à expliquer est la présence d'un matériel. Les matériaux dans Unity permettent de configurer l'aspect visuel d'une surface. On peut les utiliser pour donner une texture, une couleur, un aspect métallique ou mat, ou encore pour créer de la transparence. C'est avec les matériaux que l'on configure l'allure des objets. Puisque notre kart n'est qu'une boite, nous lui avons ajouté un matériel, que nous avons créé dans la fenêtre Projet, que nous avons ensuite modifié pour donner une couleur, et que nous avons ensuite appliqué sur le kart.


---

## Atelier Unity H20 #4
Au programme:
- Créer des objets au runtime
- Déclencher des événements en code
- Utiliser des Triggers comme checkpoints


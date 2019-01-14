# FilRouge

Le directeur d'une agence de recrutement vous a solliciter car il souhaite disposer d'un outil permettant à ses agents de recrutement de faire passer des tests "techniques" aux candidats pour s’assurer de leurs compétences, avant de les proposer à ses clients.
Il souhaite pouvoir auditer ses candidats sur diverses technologies, pour des niveaux de complexité allant de Junior à Expert, en passant par Confirmé.
Un administrateur aura la possibilité d'ajouter des agents de recrutement, de gérer le référentiel de questions et de réponses et de générer un nouveau Quiz pour un candidat.
Un agent de recrutement aura également la possibilité de générer un quiz.

Les candidats ne disposeront pas d'accès à l'application. Une fois un quiz créé pour un candidat, il sera alors possible de lancer le quiz en question à partir d'une URL ou à l’aide d’un code qui une fois transmis au candidat, pourra lancer le passage d’un quiz.
L'enregistrement des questions doit se faire au fur et à mesure afin de permettre de reprendre un quiz dans son dernier état, en cas de problème de connexion par exemple.
Un quiz pourra contenir un nombre de question qui pourra varier. Nous devons avoir la possibilité d'indiquer le nombre de question à intégrer.
Le temps de passage du quiz n'est pas à prendre en compte dans le développement de l'application. Nous gèrerons nous-même le temps que nous souhaitons octroyer à nos candidats. Dans l'idéal, un chronomètre indiquant le temps passé dans le quiz peut être affiché, mais ce n'est pas obligatoire.
Après avoir passé le quiz, le candidat fera le point sur ses résultats avec l'agent de recrutement qui a été désigné comme étant en charge du suivi de la formation.
Chaque quiz passé génèrera un "formulaire" de résultat (le calcul des résultats pourra être calculé automatiquement à la fin du quiz ou demandé par l'agent de recrutement après réalisation du quiz.
Un agent de recrutement pourra lister les quiz qui auront été passé à sa demande. Un agent de recrutement pourra alors présenter les résultats du quiz par candidat. Le résultat d'un quiz présentera le taux de bonne réponse global ET le taux de réponse  regroupé par la complexité des questions. 
 
La génération d'un quiz s'appuiera sur des taux de composition de niveau de complexité. Par exemple, lorsqu'on créera un quiz ".NET" pour un candidat "Junior", la complexité des questions pourra être ventilée de façon à ce que les questions posées soient à 70 % de niveau junior, à 20 % de niveau confirmé et à 10 % de niveau expérimenté.
 
Voici un le tableau de ventilation des complexités dans un questionnaire :
 
Quiz \ Niveau
-Junior
-Confirmé
-Expérimenté

***Junior***          ***Confirmé***        ***Expérimenté***
70 % junior           25% junior            10% junior
20 % confirmé         50% confirmé          40% confirmé
10 % Expérimenté      25% Expérimenté       50% Expérimenté

 
Indication des formateurs pour ces ratios :
Afin de faciliter le développement de l'application, ces taux peuvent être utilisés pour toutes les types de technologies créés dans l'application. Eviter cependant de "hard-coder" ces valeurs, préférez l'utilisation d'une table de paramétrage, voire d'un fichier de configuration.
 
Si le résultat présenté dans le PDF est bien mis en page, ce mode de consultation peut être suffisant.
 
Les réponses à un quiz seront paramétrées au moment de la création de la question. Une question pourra posséder une ou plusieurs bonne(s) réponse(s). Une question pourra également être une question ouverte, pour laquelle la réponse sera un champs de saisie libre. Idéalement, il serait pertinent de pouvoir disposer d'une explication à présenter au candidat dans le cas où sa réponse est fausse.
Pour chaque question, il doit être possible pour le candidat de saisir un commentaire.
Une question fausse devra être différencié d'une question non remplie par manque de temps dans le résultat.
La quantité de question libre doit être très limitée. Les réponses ne seront pas affichées au fur et à mesure lors du passage du quiz.
 
La maintenance de l'application sera réalisée par l'un des salariés qui connait les technologies suivantes :
·        ASP.NET MVC
·        ASP.NET MVC API
·        Angular 5
·        SQL Server
·        Entity Framework
·        Langage C#
 
Pour cette application, il n’existe pas de charte graphique imposée. Les candidats passeront ce quiz sont des postes de types portables ou PC fixes (pas de mobile, etc, etc)
 
Fonctionnalités attendues :
 
·        Création et édition de technologies
·        Création et édition de niveau d'expériences
·        Création et édition de questions
·        Création et édition des options de questions
·        Création et édition d'un quiz *
·        Visualisation des détails du quiz (résultat)
·        Ecran de connexion
·        Passage du quiz technique *
·        Présentation des résultats (mail, pdf, page web) *
 
*Prioriser la réalisation de ces fonctionnalités.
 
Réponses diverses :
 
·        Une question concerne un seul langage.
·        Ne pas afficher les bonnes réponses sur le PDF.
·        Le nombre de question doit-être paramétrable
·        Création de session jetable pour les candidats
·        Pas de retour arrière possible
·        Pas de gestion de temps dans l'application
·        Le salarié qui suit le dossier sera indiqué lors de la création du quiz pour un candidat.
·        Pas d'affichage de réponse immédiat
·        Peu de question libre, mais on souhaite avoir cette possibilité
·        Quiz réalisé sur PC fixe ou portable sous Windows (navigateur)
·        Il doit être possible de reprendre un quiz non terminé
·        On différenciera le faux du non rempli par manque de temps
·        Si le PDF est bien, le résultat peut-être suffisant pour la restitution
·        Ajouter un champs commentaires pour chaque question
·        Dans un premier temps, le résultat peut être affiché dans un écran simple 
·        Limitation à 40 questions maximum
·        Utilisation des radio button et checkbox pour les réponses
·        Le directeur valide ou non un candidat --> Uniquement pour la modélisation d’un cas d’utilisation
·        Un RH ne peut pas supprimer un questionnaire si il est passé par un candidat
·        Quantité de question libre à définir

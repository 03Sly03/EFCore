# Quoi qui faut faire ? et qu'est ce que ça fait quoi ?

lancer l'invite de commande et créer une instance de serveur.

Créé une classe dans le dossier Models

Lié la bdd avec la première classe créé dans le dossier Models :

Falre la première migration (dans la console du gestionnaire de package) :

Add-Migration Initial 

 |
 -> Pour annuler la migration : 
		Remove-Migration

Dans le fichier Migrations :
-> le Inital, 2 méthodes
	- up nouvelle modif
	- down revenir en arrière

Après tout changement ajouté la migration avec un nom qui défini la migration et faire un Update-Database

Update-Database 
 -> applique la migration (reviens à la dernière migration de disponible)
Update-Database 0 supprime les migrations

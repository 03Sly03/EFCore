# Quoi qui faut faire ? et qu'est ce que �a fait quoi ?

lancer l'invite de commande et cr�er une instance de serveur.

Cr�� une classe dans le dossier Models

Li� la bdd avec la premi�re classe cr�� dans le dossier Models :

Falre la premi�re migration (dans la console du gestionnaire de package) :

Add-Migration Initial 

 |
 -> Pour annuler la migration : 
		Remove-Migration

Dans le fichier Migrations :
-> le Inital, 2 m�thodes
	- up nouvelle modif
	- down revenir en arri�re

Apr�s tout changement ajout� la migration avec un nom qui d�fini la migration et faire un Update-Database

Update-Database 
 -> applique la migration (reviens � la derni�re migration de disponible)
Update-Database 0 supprime les migrations

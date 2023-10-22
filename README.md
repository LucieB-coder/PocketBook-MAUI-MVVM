# PocketBook

### Lancer l'application
Pour lancer le projet, il vous suffit de tirer le projet en local sur votre machine, de rentrer dans le dossier PocketBook et d'ouvrir la solution PocketBook.sln dans visual studio. Vous pourrez ensuite travailler avec votre IDE comme vous avez l'habitude de le faire.

Le commit à prendre en compte pour la correction est le dernier commit sur la branch master ( le commit 20ed37636bc2b8a66a4044f058646911c5f14437).

Je n'ai pas pu tester l'application sous iOS et n'ai pu travailler que sur des émulateurs/devices Android.

## Fonctionnalités
* Afficher la page avec tous les livres (avec une pagination pour faciliter la recherche d'un livre)
* Afficher la page de détails d'un livre
* Renverser l'ordre d'une liste de livres
* Accéder aux pages de filtre Auteur, Date et Note et obtenir la liste de livres correspondante au filtre choisi
* Voir les prêts et Emprunts en cours

## Naviguer dans l'application

Voici comment accéder le plus simplement à toutes les pages et éléments de pages:

* **Page bibliothèque :** Page d'accueil
* **Page de liste des livres :** clic sur le premier item dans la liste "Mes livres" de la page d'accueil (appelé "Tous") ou sur l'onglet "My Lists" de la Tabbar
* **Page affichant les détails d'un livre :** clic sur un livre dans l'onglet "My Lists"
* **Page de filtre par auteur :** clic sur le premier item dans la liste "Filtres" de la page d'accueil (appelé "Auteur") ou sur l'onglet "Search" de la Tabbar
* **Menu contextuel :** Clic sur le "+" rouge dans l'onglet "My Lists"
* **Page d'emprunt/prêt :** clic sur le premier item dans la liste "Mes livres" de la page d'accueil (appelé "En Prêt") dans la page d'accueil ou sur l'onglet "My Readings" dans laTabbar
* **Page de filtre par date :** clic sur le deuxième item dans la liste "Filtres" de la page d'accueil (appelé "Date de publication")
* **Page de filtre par note :** clic sur le troisième item dans la liste "Filtres" de la page d'accueil (appelé "Note")

> Pour les problèmes connus du TP 1, je vous invite à consulter les tickets non-fermés dans la partie Tickets du dépôt

## Problèmes connus TP 2:

* L'affichage des étoiles correspondantes à la note d'un livre ne correspondent pas à la vraie note du livre.
* Après avoir accédé à la page de liste de livre depuis une page de filtre, lorsque l'on clique sur retour, on retombe sur la page de bibliothèque et non sur la page de filtre.
* Les nombres sur la page de bibliothèque ne fonctionnent pas.
* L'affichage de la popup apparaissant lorsque l'on clique sur le **+** est contrôlé par Z-Index et non par une commande.
* Les propriété **GoToPreviousPage** et **GoToNextPage** sont typée comme RelayCommandObject et non comme ICommand

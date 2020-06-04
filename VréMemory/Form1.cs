using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllLoto;

namespace VréMemory
{
    public partial class FormMemory : Form
    {
        Random random = new Random();
        int nbCartesSurTapis;
        int nbCartesDansSabot;
        int[] tImagesCartes;
        List<int> ImagesDecouvert;
        int nb_cartes;
        PictureBox Image1;
        PictureBox Image2;
        int nb_coup;
        int coupreussi = 0;
        int i_image1 = 0, i_image2 = 0;
        int i_carte1 = 0, i_carte2 = 0;
        Boolean estDistribué;
        Boolean estenJeu;
        int score;

        
        
            public FormMemory()
        {
            InitializeComponent();
        }

        private void FormMemory_Load(object sender, EventArgs e)
        {

        }

        private void Distribuer_aleatoire()
        {

            LotoMachine hasard = new LotoMachine(nbCartesDansSabot);

            int randomNumber;
            tImagesCartes = new int[nbCartesSurTapis];
            tImagesCartes = hasard.TirageAleatoire(nbCartesSurTapis, false);
            int nb = nbCartesSurTapis;
            for (int i = 1; i <= nbCartesSurTapis / 2; i++) //boucle pour rajouter les images déjà présentes dans le tableau à la suite du tableau -> obtenir des paires
            {
                nb += 2;
                tImagesCartes[nb / 2] = tImagesCartes[i];
            }
            //tImagesCartes[5] = tImagesCartes[1];
            //tImagesCartes[6] = tImagesCartes[2];
            //tImagesCartes[7] = tImagesCartes[3];
            //tImagesCartes[8] = tImagesCartes[4];
            List<int> liste = new List<int>(tImagesCartes); //on transforme en liste pour simplifier la suite

            // La série d'entiers retournée par la LotoMachine correspondra
            // aux indices des cartes dans le "sabot"
            // Affectation des images aux picturebox
            PictureBox carte;
            for (int i_carte = 0; i_carte < nbCartesSurTapis; i_carte++)
            {
                randomNumber = random.Next(1, liste.Count);

                carte = (PictureBox)tlpTapisDeCartes.Controls[i_carte];

                carte.Image = ilSabotDeCartes.Images[liste[randomNumber]];
                tImagesCartes[i_carte + 1] = liste[randomNumber];
                liste.RemoveAt(randomNumber); //on supprime la valeur pour ne pas l'avoir encore une fois
            }
        }
        private void retourner()
        {
            PictureBox carte;
            foreach (Control ctrl in tlpTapisDeCartes.Controls)
            {// Je sais que le contrôle est une PictureBox
             // donc je "caste" l'objet (le Contrôle) en PictureBox..
                carte = (PictureBox)ctrl;
                // Ensuite je peux accéder à la propriété Image
                // (je ne pourrais pas si je n'avais pas "casté" le contrôle)
                carte.Image = ilSabotDeCartes.Images[0];

            }
        }
        private void RetournerLesCartes(object img1, object img2) //retourne les cartes quand mauvaise paire
        {
            nb_cartes = 0;
            PictureBox carte1; PictureBox carte2;
            carte1 = (PictureBox)img1;
            carte2 = (PictureBox)img2;
            carte1.Image = ilSabotDeCartes.Images[0];
            carte2.Image = ilSabotDeCartes.Images[0];
        }
        private void RetournerLaCarte(object img1) //pour retourner la carte quand 2 clique sur la même image
        {
            nb_cartes = 0;
            PictureBox carte1;
            carte1 = (PictureBox)img1;
            carte1.Image = ilSabotDeCartes.Images[0];

        }

        private void btn_Distribuer_Click(object sender, EventArgs e)
        {
            nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;
            nbCartesSurTapis = tlpTapisDeCartes.Controls.Count;
            nb_cartes = 0;

            nb_coup = 0;
            nb_coups.Text = nb_coup.ToString();
            Distribuer_aleatoire();
            estDistribué = true;
        }

        private async void RetourneCarte(object sender)
        {
            String lab;
            String str_score;
            if (estenJeu)
            {
                PictureBox carte;
                


                if (nb_cartes < 2)
                {
                    carte = (PictureBox)sender;
                    int i_carte = Convert.ToInt32(carte.Tag);
                    int i_vraicarte = i_carte + (nbCartesSurTapis / 2); //pour avoir la vrai position, car pb d'inversion des lignes
                    if (i_vraicarte > nbCartesSurTapis)//si index supérieur au nb de cartes sur tapis
                    {
                        i_vraicarte = i_vraicarte % nbCartesSurTapis;//on lui assigne le reste de la division par ce nb
                    }
                    int i_image = tImagesCartes[i_vraicarte];
                    carte.Image = ilSabotDeCartes.Images[i_image];

                   
                   

                    if (nb_cartes == 0)
                    {
                        Image1 = carte;
                        i_carte1 = Convert.ToInt32(carte.Tag);
                        i_image1 = tImagesCartes[i_vraicarte];
                    }

                    

                    if (nb_cartes == 1)
                    {

                        Image2 = carte;
                        i_carte2 = Convert.ToInt32(carte.Tag);
                        i_image2 = tImagesCartes[i_vraicarte];
                    }
                    //Verifie si l'image cliquée a deja été decouverte

                    nb_cartes++;
                        foreach (int imageD in ImagesDecouvert)
                        {
                            if (imageD == i_image)
                            {
                                MessageBox.Show("Cette carte a été decouverte");
                                if (imageD == i_image2)
                                {
                                    if (imageD != i_image1)
                                    {
                                    nb_cartes = 3;
                                    await Task.Delay(TimeSpan.FromSeconds(0.5));
                                    RetournerLaCarte(Image1);
                                    }
                                }
                                nb_cartes = 0;
                                break;
                            }
                        }
                    
                }
                    

                   

                if (nb_cartes == 2)
                {

                    if (i_image1 == i_image2)
                    {
                        if (i_carte1 != i_carte2) //on vérifie que le joueur n'a pas cliqué deux fois sur la même image
                        {
                            nb_coup++;
                            MessageBox.Show("Bravo !");
                            coupreussi++;
                            nb_cartes = 0;
                            // on ajoute les images decouvertes 
                            ImagesDecouvert.Add(i_image1);
                            score+= 100;     
                            
                        }
                        else
                        {
                            MessageBox.Show("Vous avez cliqué sur la même carte.");

                            nb_cartes = 3;
                            await Task.Delay(TimeSpan.FromSeconds(0.5));

                            RetournerLaCarte(Image1);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Dommage, essayez encore !");
                        nb_cartes++;
                        await Task.Delay(TimeSpan.FromSeconds(0.5));
                        RetournerLesCartes(Image1, Image2);
                        nb_coup++;
                        score -= 50;

                    }

                }
                if(nb_cartes > 2)
                {
                    MessageBox.Show("Il faut attendre que les cartes se retournent.");
                }
               
                //actualise le nombre d'essai et le score
                lab = nb_coup.ToString();
                nb_coups.Text = lab;
                str_score = score.ToString();
                lab_score.Text = str_score;

                if (coupreussi == nbCartesSurTapis / 2) //on vérifie si toutes les cartes on été découvertes
                {
                    Reussite();
                }
            }
            else
            {
                MessageBox.Show("Il faut démarrer le jeu avant de pouvoir retourner les cartes.");
            }
        }

        private void btn_Retourner_Click(object sender, EventArgs e)
        {
            if (nb_cartes == 1)
            {
                MessageBox.Show("On ne triche pas !");
            }
            else
            {
                retourner();
            }
        }

        private void btn_Jouer_Click(object sender, EventArgs e)
        {
            if (estDistribué)
            {
                retourner();
                nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;
                nbCartesSurTapis = tlpTapisDeCartes.Controls.Count;
                timer1.Start();
                estenJeu = true;
                nb_coup = 0;
                coupreussi = 0;
                nb_cartes = 0;
                score = 0;
                ImagesDecouvert =  new List<int> { -1 };
            }
            else
            {
                MessageBox.Show("Il faut distribuer avant de jouer.");
            }

        }
    

        private void pb_01_Click(object sender, EventArgs e)
        {
            RetourneCarte(sender);
        }

        private void pb_02_Click(object sender, EventArgs e)
        {
            RetourneCarte(sender);

        }

        private void pb_03_Click(object sender, EventArgs e)
        {
            RetourneCarte(sender);

        }

        private void pb_04_Click(object sender, EventArgs e)
        {
            RetourneCarte(sender);

        }

        private void pb_06_Click(object sender, EventArgs e)
        {
            RetourneCarte(sender);

        }

        private void pb_08_Click(object sender, EventArgs e)
        {
            RetourneCarte(sender);

        }

        private void pb_07_Click(object sender, EventArgs e)
        {
            RetourneCarte(sender);

        }

        private void pb_05_Click(object sender, EventArgs e)
        {
            RetourneCarte(sender);

        }

    
                                                   
        private void Reussite()
        {
           
            if (score > 0)
            {
                MessageBox.Show("Bravo, vous avez trouvé toutes les paires en " + nb_coup + " coups ! Votre score est : " + score);
            }
            else
            {
                MessageBox.Show("Vous avez trouvé toutes les paires en " + nb_coup + " coups ! Malheureusement, votre score est : " + score + ". :(");
            }

            // Reinitialisation 
            tImagesCartes = null;
            estDistribué = false;
            estenJeu = false;
            nb_cartes = 0;

            nb_coup = 0;
            nb_coups.Text = nb_coup.ToString(); 

            PictureBox carte;

            foreach (Control obj in tlpTapisDeCartes.Controls)
            {
                carte = (PictureBox)obj;
                carte.Image = null;
            }
        }
    }
}
  


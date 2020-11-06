using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachineGame_Drafts_Lanza
{
    //Written by Rodney Drafts and Dominic Lanza
    //Class: Image List
    //Class Description: This class creates the ImageList we use in the visual display of the slotmachine game
    public class ImageList
    {
        //amount of images we want in the bitmap
        private static int capacity = 4;
        //creating an array of type Bitmap.
        private Bitmap[] images = new Bitmap[capacity];

        //constructor instaniating buildList method
        public ImageList()
        {
            buildList();
        }

        //Build the Bitmap List populating it with images
        private void buildList()
        {
            images[0] = new Bitmap(Properties.Resources.one);
            images[1] = new Bitmap(Properties.Resources.two);
            images[2] = new Bitmap(Properties.Resources.three);
            images[3] = new Bitmap(Properties.Resources.four);
         
        }

        //Add image to the Bitmap
        public void Add(Bitmap x)
        {
            images[capacity] = x;
            capacity += 1;
        }

        //Get image method
        public Bitmap getImage(int i)
        {
            if(i > capacity - 1)
            {
                return images[capacity-1];
            }
            else
            {
                return images[i];
            }
            
        }
        //Select an image randomly
        public Bitmap getRanImage()
        {
            RandomNumber ran = new RandomNumber();
            int x = ran.pickRandom();
            return images[x];
        }




    }
}

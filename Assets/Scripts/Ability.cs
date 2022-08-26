using SnakeGame;
using UnityEngine;

namespace DefaultNamespace
{
    public interface IAbilityService
    {
        
    }

    public class Ability : MonoBehaviour            //Single Ability class for this ability
    {
        public Food food;
        public AbilityView view;        //AbilityView class reference
        public int count;           //variable for Counter
        
        public void Use(FoodEnum foodEnum)               //Method for using this ability
        {
            switch (foodEnum)
            {
                case FoodEnum.AbilityAdds5Foods:
                    for (int i = 0; i < 5; i++)
                    {
                        Food foodAgain = Instantiate(food);
                        foodAgain.Initialize();
                    }
                    
                    break;
                case FoodEnum.AbilityRainbow:
                    
                    break;
                case FoodEnum.AbilityFoodMagnet:
                    
                    break;
            }
            
            count -= 1;
            //snake does something
            
        }

        public void OnAbilityCollected()
        {
            count += 1;
            view.count.text = count.ToString();

        }
        
        
        
        //counter ADD if ABILITY COLLECTED
        //counter SUBTRACT if ABILITY USED
    }
}
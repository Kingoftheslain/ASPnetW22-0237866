using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MichaelsPathFinderRazorPages.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MichaelsPathfinderRazorPagesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MichaelsPathfinderRazorPagesContext>>()))
            {
                //Looking for Feats.
                if (context.Feats.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Feats.AddRange(
                    new Feats
                    {
                        featName = "Defensive Stance",
                        FeatLearnedDate = DateTime.Parse("2021-07-02"),
                        shortDescription = "You can increase your defense at the expense of your accuracy.",
                        description = "You can choose to take a -1 penalty on melee attack rolls and combat maneuver checks to gain a +1 dodge bonus to your Armor Class. When your base attack bonus reaches +4, the penalty increases by -1 and the dodge bonus increases by +1.You must choose to use Defensive Stance before making an attack roll and its effects last until your next turn."
                    }, 

                    new Feats
                    {
                        featName = "Risky Strike",
                        FeatLearnedDate = DateTime.Parse("2021-07-02"),
                        shortDescription = "You can increase your attack at the expense of your accuracy.",
                        description = "You can choose to take a –1 penalty on all attack rolls and combat maneuver checks to gain a +2 bonus on all damage rolls. This bonus to damage is increased by half (+50%) if you are making an attack with a two-handed weapon, a one handed weapon using two hands, or a primary natural weapon that adds 1-1/2 times your Strength modifier on damage rolls. This bonus to damage is halved (–50%) if you are making an attack with an off-hand weapon or secondary natural weapon.When your base attack bonus reaches +4, and every 4 points thereafter, the penalty increases by –1 and the bonus to damage increases by +2.You must choose to use Risky Strike before making an attack roll, and its effects last until your next turn. The bonus damage does not apply to touch attacks or effects that do not deal hit point damage."
                    },

                    new Feats
                    {
                        featName = "Exotic Weapon Proficiency",
                        FeatLearnedDate = DateTime.Parse("2021-07-02"),
                        shortDescription = "You can use a weapon extemely efficently compared to others",
                        description = "Choose one type of exotic weapon, such as the spiked chain or whip. You understand how to use that type of exotic weapon in combat, and can utilize any special tricks or qualities that exotic weapon might allow."
                    },

                    new Feats
                    {
                        featName = "Two Weapon Fighting",
                        FeatLearnedDate = DateTime.Parse("2021-07-02"),
                        shortDescription = "You can fight with a weapon wielded in each of your hands. You can make one extra attack each round with the secondary weapon.",
                        description = "Your penalties on attack rolls for fighting with two weapons are reduced. The penalty for your primary hand lessens by 2 and the one for your off hand lessens by 6. See Two-Weapon Fighting.  Normally, if you wield a second weapon in your off hand, you can get one extra attack per round with that weapon. When fighting in this way you suffer a -6 penalty with your regular attack or attacks with your primary hand and a -10 penalty to the attack with your off hand. If your off-hand weapon is light, the penalties are reduced by 2 each. An unarmed strike is always considered light."
                    },

                    new Feats
                    {
                        featName = "Improved Shield Bash",
                        FeatLearnedDate = DateTime.Parse("2021-07-02"),
                        shortDescription = "When you perform a shield bash, you may still apply the shields shield's bonus to your AC",
                        description = "Without this feat, a character that performs a shield bash loses the shield's shield bonus to AC until his next turn (see Equipment)"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

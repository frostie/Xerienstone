# Stone-Smasher
A 2D block breaker game.

## Game Design

### Points & Effects

#### Regular Blocks
- Bronze Block - 6 pts
- Silver Block - 12 pts
- Gold Block - 24 pts
- Platinum Block - 48 pts

#### Elemental Blocks
- Ice Block - 100 pts; slows down game speed for 10 seconds
- Fire Block - 100 pts; destroys blocks within 1 unit radius

#### Special Blocks
- Black Diamond - 200 pts

#### Orbs
// Orbs are held in place by stones and will fall once the stones holding it are destroyed.
- Crystal Orb - ??

#### Special Items
- Power Ball - destroys all blocks in one hit without bouncing back for 5 seconds
- Machine Gun - machine gun fires bullets from paddle for 5 seconds
- Multi Ball - fires 10 disposable balls to accompany the main ball in destroying stones 

## Level Design
### Level 1:
- 1-hit stones (30)

### Level 2:
- 1-hit stones (30)
- 2-hit stones (3)

## Next Actions
- Add three lives per game session
  - When ball collides with LoseCollider:
      - playerLives -= 1
      - reset ball position to paddle
  - When playerLives <= 0, show Game Over screen
- Choose theme for game
- Create original logo and sprites
- Name game (current name is placeholder)
- Record original sound effects and music
- Add core gameplay screenshots to GitHub to illustrate elements of game
- Write code to track user high scores in online database

## Credits
- Foundational code provided by Ben Tristem's and Rick Davidson's "Complete C# Unity Developer 2D: Learn to Code Making Games" tutorials

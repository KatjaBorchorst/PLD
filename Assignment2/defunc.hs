m' (g) z = (g) z

bizarre' () g x = m' (g) x

mango f u v = f v u

plip' (w) k m = (w) k m 

plop' (w) n = plip' (w) n 484000

dingo' () w = plop' (w) 17

plys x y = x + 4

ninka x = 0 - x

zap x y = x*y

mina' = mango plys (bizarre' () ninka) (dingo' () zap)

--defunc herunder

eval (M (g)) z = eval g z

eval (Bizarre ()) (g, z) = eval (M (g)) x

eval (Mango ()) f u v = eval f v u -- Skal argumenterene være i parentes?

eval (Plip (w)) k m = eval w k m -- Igen argumenter i parentes?. I slides har de kun 1 på højre side af de implicit. Idk man

eval (Plop (w)) n = eval (Plip (w)) n 484000

eval (Dingo ()) w = eval (Plop (w)) 17

eval (Plys ()) x y = eval x + 4

eval (Ninka ()) x = 0 - eval x

eval (Zap ()) x y = eval x * eval y

eval (Mina ()) = eval mango () (eval (Plys () (eval Bizarre () ninka) (eval Dingo () (eval Zap ()))))
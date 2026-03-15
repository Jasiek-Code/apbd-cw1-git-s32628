1. 
Merge nie był fast-forward, ponieważ po utworzeniu gałęzi feature-max na gałezi main pojawiły się nowe oddzielne zmiany. 
Git nie mogł po prostu przesunąć heada na feature-max i musiał połączyć te historie zmian tworząc nowy commit - merge commit.

2. 
Merge zcala gałęzie zachowując historię pracy.
Rebase odcina commity z jednej gałęzi i dokleja na koniec gałęzi drugiej. Sprawia to, że historia jest płaska ale zmieniają się hashe przeniesionych commitów.

3. Konflikt został rozwiązany poprzez wskazanie, który fragment kodu ma zostać poprzez ręczną edycję pliku i zcommitowanie merga
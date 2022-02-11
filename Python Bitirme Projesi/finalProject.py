"""
1- Bir listeyi düzleştiren (flatten) fonksiyon yazın. Elemanları birden çok katmanlı listelerden ([[3],2] gibi) oluşabileceği gibi, non-scalar verilerden de oluşabilir. Örnek olarak:

input: [[1,'a',['cat'],2],[[[3]],'dog'],4,5]

output: [1,'a','cat',2,3,'dog',4,5]
"""

x=[[1,'a',['cat'],2],[[[3]],'dog'],4,5]
yeni = []
def duzlestir(elemanlar):
    for eleman in elemanlar:
        if type(eleman) == list:
            duzlestir(eleman)
        else:
            yeni.append(eleman)
duzlestir(x)
print(yeni)


"""
2- Verilen listenin içindeki elemanları tersine döndüren bir fonksiyon yazın. Eğer listenin içindeki elemanlar da liste içeriyorsa onların elemanlarını da tersine döndürün. Örnek olarak:

input: [[1, 2], [3, 4], [5, 6, 7]]

output: [[[7, 6, 5], [4, 3], [2, 1]]
"""
liste=[1, 'a', 'cat', 2, 3, 'dog', 4, 5]
tersCevir = liste.reverse()
print(liste)
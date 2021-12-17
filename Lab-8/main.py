# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.

from Clusterer import Clusterer





if __name__ == '__main__':
    clusterer = Clusterer('data.txt', 15)

    #clusterer.mean_shift()
    #clusterer.affinity_propagation()
    #clusterer.kmeans()
    #clusterer.dbscan()
    #clusterer.agglomerative_clustering()
    clusterer.show_all()


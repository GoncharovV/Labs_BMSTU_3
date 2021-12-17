# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.
import matplotlib.pyplot as plt
from sklearn.cluster import KMeans, AffinityPropagation, MeanShift, estimate_bandwidth, DBSCAN, AgglomerativeClustering
import numpy as np

color_theme = np.array(
    ['gray', 'black', 'blue', 'red', 'pink', 'orange', 'pink',
     'yellow', 'purple', 'brown', 'salmon', 'powderblue', 'darkgray', 'cyan',
     'green'])


class Clusterer:
    def __init__(self, data_file_path):
        file = open(data_file_path)
        lines = file.readlines()
        file.close()

        self.x = []
        self.y = []

        for i in range(len(lines)):
            splited = lines[i].strip().split('   ')
            self.x.append(splited[0])
            self.y.append(splited[1])

        self.lines = []

        for i in range(len(self.x)):
            self.lines.append([self.x[i], self.y[i]])

    def __draw(self, labels):
        plt.scatter(self.x, self.y, c=color_theme[labels])
        # plt.title('Clustering')

        plt.show()

    def kmeans(self):
        kmeans = KMeans(n_clusters=15)
        KMeans_model = kmeans.fit(self.lines)
        self.__draw(KMeans_model.labels_)

    def affinity_propagation(self):
        af = AffinityPropagation(max_iter=50, damping=0.6)
        af_model = af.fit(self.lines)
        self.__draw(af_model.labels_)

    def mean_shift(self):
        ms = MeanShift(bandwidth=100000, max_iter=50, bin_seeding=True)
        ms_model = ms.fit(self.lines)
        self.__draw(ms_model.labels_)

    def dbscan(self):
        db = DBSCAN(eps=50000, min_samples=150).fit(self.lines)
        self.__draw(db.labels_)

    def agglomerative_clustering(self):
        ac = AgglomerativeClustering(n_clusters=15).fit(self.lines)
        self.__draw(ac.labels_)


if __name__ == '__main__':
    clusterer = Clusterer('data.txt')

    # clusterer.mean_shift()
    # clusterer.affinity_propagation()
    clusterer.kmeans()
    # clusterer.dbscan()
    # clusterer.agglomerative_clustering()

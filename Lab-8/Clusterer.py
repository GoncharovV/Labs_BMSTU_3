import matplotlib.pyplot as plt
from sklearn.cluster import KMeans, AffinityPropagation, MeanShift, estimate_bandwidth, DBSCAN, AgglomerativeClustering
import numpy as np

color_theme = np.array(
    ['gray', 'black', 'blue', 'red', 'pink', 'orange', 'pink',
     'yellow', 'purple', 'brown', 'salmon', 'powderblue', 'darkgray', 'cyan',
     'green'])


class Clusterer:
    def __init__(self, file_path, cluster_count):
        file = open(file_path)
        self.data = [np.array(list(map(int, x.strip().split('   ')))) for x in file.readlines()]
        file.close()

        self.cluster_count = cluster_count

        self.x = [x for [x, _] in self.data]
        self.y = [y for [_, y] in self.data]

    def kmeans(self):
        kmeans = KMeans(n_clusters=self.cluster_count).fit(self.data)

        self.labels = kmeans.labels_

    def affinity_propagation(self):
        af = AffinityPropagation(damping=0.95, random_state=3).fit(self.data)
        print(*af.labels_)
        print(len(af.cluster_centers_))
        self.labels = af.labels_

    def mean_shift(self):
        ms = MeanShift(bandwidth=100000, max_iter=50, bin_seeding=True).fit(self.data)
        self.labels = ms.labels_

    def dbscan(self):
        db = DBSCAN(eps=55000, min_samples=100).fit(self.data)
        self.labels = db.labels_

    def agglomerative_clustering(self):
        ac = AgglomerativeClustering(n_clusters=self.cluster_count).fit(self.data)
        self.labels = ac.labels_

    def show(self):
        plt.scatter(self.x, self.y, c=color_theme[self.labels])
        plt.title('Clustering')

        plt.show()

    def show_all(self):
        fig, ((ax1, ax2, ax3), (ax4, ax5, ax6)) = plt.subplots(2, 3)
        fig.set_size_inches(16.5, 9.5)

        self.kmeans()
        ax1.scatter(self.x, self.y, c=color_theme[self.labels])
        ax1.set_title('KMeans')

        print(color_theme[self.labels])

        self.agglomerative_clustering()
        ax2.scatter(self.x, self.y, c=color_theme[self.labels])
        ax2.set_title('AgglomerativeClustering')

        self.mean_shift()
        ax3.scatter(self.x, self.y, c=color_theme[self.labels])
        ax3.set_title('MeanShift')

        self.dbscan()
        ax4.scatter(self.x, self.y, c=color_theme[self.labels])
        ax4.set_title('DBSCAN')

        self.affinity_propagation()

        self.labels = [x % len(color_theme) for x in self.labels]

        ax5.scatter(self.x, self.y, c=color_theme[self.labels])
        ax5.set_title('AffinityPropagation')

        plt.show()

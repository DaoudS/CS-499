import json
from typing import Collection
from pymongo import MongoClient
from bson.objectid import ObjectId
from pymongo import *
from pymongo.results import DeleteResult
import json
from bson import json_util


class AnimalShelter():
    """ CRUD operations for Animal collection in MongoDB """
    def __init__(self, username, password):
        # Initializing the MongoClient. This helps to
        # access the MongoDB databases and collections.
        self.username = username
        self.password = password
        self.client = MongoClient(
            'mongodb://%s:%s@localhost:27017' % (self.username, self.password))
        self.database = self.client["AAC"]
        self.collection = self.database["animals"]

    def create(self, data):
        """Create document in DB.

        Keyword arguments:
        data -- Document in dictonary format
        """
        if data is not None:
            self.collection.insert(data)  # Data is of type dictionary
            return True
        else:
            raise Exception("Data Param is empty")

    def read(self, data):
        """Read document from DB.

        Keyword arguments:
        data -- Document in dictonary format
        """
        if data is not None:
            results = self.collection.find(data, {'_id': False})
            return results
        else:
            raise Exception("Data Param is empty")

    def update(self, filter, update):
        """Update document in DB.

        Keyword arguments:
        filter -- dictonary with db document to select
        update -- dictonary with changes to the filtered db document
        """
        if filter and update is not None:
            data_result = self.collection.update_one(filter, update)
            return data_result
        else:
            raise Exception("Data Param is empty")

    def delete(self, data):
        """Delete document in DB.

        Keyword arguments:
        data -- Document in dictonary format to deltee
        """
        if data is not None:
            self.collection.delete_one(data)
        else:
            raise Exception("Data Param is empty")
